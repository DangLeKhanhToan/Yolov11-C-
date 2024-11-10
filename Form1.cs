using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Detection_YOLOv11
{
    
    public partial class ComputerVision : Form
    {
        private string[] imageFiles;
        private int currentIndex;
        private bool isWebcamActive;
        private bool isYoloActive;
        private VideoCaptureDevice webcam;
        private FilterInfoCollection webcamDevices;
        private YOLO_Detector _detector;


        public ComputerVision()
        {
            InitializeComponent();
            currentIndex = 0;
            isWebcamActive = false;
            isYoloActive = false;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            string modelPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "weights", "yolo11s.onnx");
            _detector = new YOLO_Detector("D:/_KhanhToanLevi_/_2025_/Prepare for Jobs/Project/C# Detection app/Detection_YOLOv11/weights/yolo11n.onnx");
            
        }
        // App feature
        private void Btn_OpenFolder_Click(object sender, EventArgs e)
        {
            if (isWebcamActive)
            {
                StopWebcam();
            }

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder containing images";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    imageFiles = Directory.GetFiles(folderPath, "*.*")
                                           .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                                       f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                                       f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                                       f.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                                           .ToArray();
                    currentIndex = 0;

                    if (imageFiles.Length > 0)
                    {
                        DisplayImage();
                    }
                    else
                    {
                        MessageBox.Show("No images found in the selected folder.", "No Images", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void DisplayImage()
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                pictureBox.ImageLocation = imageFiles[currentIndex];

                if (isYoloActive) {
                    var image = new Bitmap(pictureBox.Image);
                    var detections = _detector.DetectObjects(image);
                    using (var graphics = Graphics.FromImage(image))
                    {
                        foreach (var detection in detections)
                        {
                            var rect = detection.BoundingBox;
                            graphics.DrawRectangle(Pens.Red, rect);
                            graphics.DrawString($"{detection.Label}: {detection.Confidence:F2}",
                                new Font("Arial", 12), Brushes.Red, rect.X, rect.Y - 20);
                        }
                    }
                    pictureBox.Image = image;
                }



                UpdateImageCounter();
            }
        }
        private void UpdateImageCounter()
        {
            if (isWebcamActive)
            {
                Label_Picture.Text = "Webcam";
            }
            else
            {
                Label_Picture.Text = $"Image {currentIndex + 1}/{imageFiles?.Length ?? 0}";
            }

            Btn_Next.Enabled = !isWebcamActive;
            Btn_Previous.Enabled = !isWebcamActive;
        }
        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (imageFiles != null && imageFiles.Length > 0 && currentIndex < imageFiles.Length - 1)
            {
                currentIndex++;
                DisplayImage();
            }
        }
        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            if (imageFiles != null && imageFiles.Length > 0 && currentIndex > 0)
            {
                currentIndex--;
                DisplayImage();
            }
        }
        private void Btn_Webcam_Click(object sender, EventArgs e)
        {
            if (isWebcamActive)
            {
                StopWebcam();
            }
            else
            {
                StartWebcam();
            }

            UpdateImageCounter();
        }
        private void StartWebcam()
        {
            isWebcamActive = true;

            // Get available webcams
            webcamDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (webcamDevices.Count == 0)
            {
                MessageBox.Show("No webcam detected.");
                isWebcamActive = false;
                return;
            }

            // Initialize webcam device
            webcam = new VideoCaptureDevice(webcamDevices[0].MonikerString);
            webcam.NewFrame += new NewFrameEventHandler(Webcam_NewFrame);
            webcam.Start();
        }
        private void StopWebcam()
        {
            isWebcamActive = false;

            if (webcam != null && webcam.IsRunning)
            {
                webcam.SignalToStop();
                webcam.NewFrame -= new NewFrameEventHandler(Webcam_NewFrame);
                pictureBox.Image = null;
            }
        }
        private void Webcam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image?.Dispose();
            var frame = (System.Drawing.Bitmap)eventArgs.Frame.Clone();
            // Reverse the image horizontally
            frame.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipX);
            
            if (isYoloActive) {
                var image = frame;
                var detections = _detector.DetectObjects(image);
                using (var graphics = Graphics.FromImage(image))
                {
                    foreach (var detection in detections)
                    {
                        var rect = detection.BoundingBox;
                        graphics.DrawRectangle(Pens.Red, rect);
                        graphics.DrawString($"{detection.Label}: {detection.Confidence:F2}",
                            new Font("Arial", 12), Brushes.Red, rect.X, rect.Y - 20);
                    }
                }
                frame = image;
            }


            pictureBox.Image = frame;


        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {

        }
        // Model Feature

        private void Btn_Activate_Click(object sender, EventArgs e)
        {
            if (isYoloActive) isYoloActive = false;
            else { 
                // If Webcam not active show Image again with detection
                isYoloActive = true;
                if (isWebcamActive == false) DisplayImage();
            }
        }

        private void Btn_AddModel_Click(object sender, EventArgs e)
        {

        }

        private void Btn_RemoveModel_Click(object sender, EventArgs e)
        {

        }




        private void ComputerVision_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopWebcam();
        }


    }


    public class YOLO_Detector
    {
        private readonly InferenceSession _session;

        public YOLO_Detector(string modelPath)
        {
            _session = new InferenceSession(modelPath);
        }

        public List<DetectionResult> DetectObjects(Bitmap image)
        {   
            var inputTensor = PreprocessImage(image);
            var inputs = new List<NamedOnnxValue> { NamedOnnxValue.CreateFromTensor("images", inputTensor) };
            using (var results = _session.Run(inputs))
            {
                var output = results.First().AsTensor<float>();
                Console.WriteLine("Detections: {0}", results);
                return PostProcess(output, image.Width, image.Height);
            }
        }

        private Tensor<float> PreprocessImage(Bitmap image)
        {
            const int targetWidth = 640;
            const int targetHeight = 640;

            using (var resizedImage = new Bitmap(image, new Size(targetWidth, targetHeight))) {
                var input = new DenseTensor<float>(new[] { 1, 3, targetHeight, targetWidth });

                for (int y = 0; y < targetHeight; y++)
                {
                    for (int x = 0; x < targetWidth; x++)
                    {
                        Color pixel = resizedImage.GetPixel(x, y);
                        input[0, 0, y, x] = pixel.R / 255.0f;
                        input[0, 1, y, x] = pixel.G / 255.0f;
                        input[0, 2, y, x] = pixel.B / 255.0f;
                    }
                }
                return input;
            }
            
        }

        private List<DetectionResult> PostProcess(Tensor<float> output, int originalWidth, int originalHeight)
        {
            const float confidenceThreshold = 0.25f;

            var results = new List<DetectionResult>();
            int numDetections = output.Dimensions[1];
            

            for (int i = 0; i < numDetections; i++)
            {
                float confidence = output[0, i, 4];
                if (confidence < confidenceThreshold) continue;

                float x = output[0, i, 0];
                float y = output[0, i, 1];
                float width = output[0, i, 2];
                float height = output[0, i, 3];

                var classProbabilities = new float[output.Dimensions[2] - 5];
                for (int j = 0; j < classProbabilities.Length; j++)
                {
                    classProbabilities[j] = output[0, i, 5 + j];
                }

                // Find the index of the class with the highest probability
                int classIndex = Array.IndexOf(classProbabilities, classProbabilities.Max());
                float classConfidence = output[0, i, 5 + classIndex];

                if (classConfidence * confidence < confidenceThreshold) continue;

                int xMin = (int)((x - width / 2) * originalWidth);
                int yMin = (int)((y - height / 2) * originalHeight);
                int xMax = (int)((x + width / 2) * originalWidth);
                int yMax = (int)((y + height / 2) * originalHeight);

                results.Add(new DetectionResult
                {
                    Label = $"Class {classIndex}",  // Use actual class names if available
                    Confidence = classConfidence * confidence,
                    BoundingBox = new Rectangle(xMin, yMin, xMax - xMin, yMax - yMin)
                });
            }
            return results;
        }
    }

    public class DetectionResult
    {
        public string Label { get; set; }
        public float Confidence { get; set; }
        public Rectangle BoundingBox { get; set; }
    }




}
