using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


        }
        static Bitmap bmPhoto = new Bitmap(384, 384,
                          PixelFormat.Format24bppRgb);

        List<Image> imageList = new List<Image>();

        List<Image> copyImageList = new List<Image>();

        static int moveCount = 0;
        






        private void button19_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            List<Image> yeniListe = imageList.OrderBy<Image, int>((item) => rnd.Next()).ToList();

            pictureBox1.Image = yeniListe[0];
            pictureBox2.Image = yeniListe[1];
            pictureBox3.Image = yeniListe[2];
            pictureBox4.Image = yeniListe[3];
            pictureBox5.Image = yeniListe[4];
            pictureBox6.Image = yeniListe[5];
            pictureBox7.Image = yeniListe[6];
            pictureBox8.Image = yeniListe[7];
            pictureBox9.Image = yeniListe[8];
            pictureBox10.Image = yeniListe[9];
            pictureBox11.Image = yeniListe[10];
            pictureBox12.Image = yeniListe[11];
            pictureBox13.Image = yeniListe[12];
            pictureBox14.Image = yeniListe[13];
            pictureBox15.Image = yeniListe[14];
            pictureBox16.Image = yeniListe[15];



            if (correctPiecesCount() >= 1)
            {
                button19.Enabled = false;
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
                pictureBox13.Enabled = true;
                pictureBox14.Enabled = true;
                pictureBox15.Enabled = true;
                pictureBox16.Enabled = true;
            }
            else
            {
                button19.Enabled = true;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;
                pictureBox11.Enabled = false;
                pictureBox12.Enabled = false;
                pictureBox13.Enabled = false;
                pictureBox14.Enabled = false;
                pictureBox15.Enabled = false;
                pictureBox16.Enabled = false;

            }

            //pictureBox16.Image.


        }

        private void button18_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image =null;
            pictureBox11.Image =null;
            pictureBox12.Image =null;
            pictureBox13.Image =null;
            pictureBox14.Image =null;
            pictureBox15.Image =null;
            pictureBox16.Image =null;
            pictureBox17.Image = null;
            pictureBox18.Image = null;
            bmPhoto = null;
            bmPhoto = new Bitmap(384, 384,
                          PixelFormat.Format24bppRgb);
            copyImageList.Clear();
            imageList.Clear();
            moveCount = 0;
            button17.Enabled = true;
            button19.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
            pictureBox13.Enabled = false;
            pictureBox14.Enabled = false;
            pictureBox15.Enabled = false;
            pictureBox16.Enabled = false;

            var lines = File.ReadAllLines(@"C:\Users\yagiz\Documents\GitHub\PuzzleGameFinal\PuzzleGame\PuzzleGame\yuksekskor.txt");
            List<int> stringList = new List<int>();
            for (int i = 0; i < lines.Length; i++)
            {
                stringList.Add(Convert.ToInt32(lines[i]));
            }
            foreach (var str in stringList)
            {
                listBox1.Items.Remove(str);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button17_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            button19.Enabled = true;
            of.Filter = "Image Files(*.jpg; *.jpeg; *.gif; .bmp)|.jpg; *.jpeg; *.gif; *.bmp";
            if (of.ShowDialog() == DialogResult.OK)
            {

                //pictureBox17.Image = new Bitmap(of.FileName);
                //pictureBox17.ImageLocation = of.FileName;
                var newPhoto = resizeImage(384, 384, of.FileName);
                Bitmap bmp = (Bitmap)newPhoto;
                pictureBox1.Image = divide(bmp, 0, 0, 96, 96);
                pictureBox2.Image = divide(bmp, 96, 0, 192, 96);
                pictureBox3.Image = divide(bmp, 192, 0, 288, 96);
                pictureBox4.Image = divide(bmp, 288, 0, 384, 96);
                pictureBox5.Image = divide(bmp, 0, 96, 96, 192);
                pictureBox6.Image = divide(bmp, 96, 96, 192, 192);
                pictureBox7.Image = divide(bmp, 192, 96, 288, 192);
                pictureBox8.Image = divide(bmp, 288, 96, 384, 192);
                pictureBox9.Image = divide(bmp, 0, 192, 96, 288);
                pictureBox10.Image = divide(bmp, 96, 192, 192, 288);
                pictureBox11.Image = divide(bmp, 192, 192, 288, 288);
                pictureBox12.Image = divide(bmp, 288, 192, 384, 288);
                pictureBox13.Image = divide(bmp, 0, 288, 96, 384);
                pictureBox14.Image = divide(bmp, 96, 288, 192, 384);
                pictureBox15.Image = divide(bmp, 192, 288, 288, 384);
                pictureBox16.Image = divide(bmp, 288, 288, 384, 384);

                imageList.Add(pictureBox1.Image);
                imageList.Add(pictureBox2.Image);
                imageList.Add(pictureBox3.Image);
                imageList.Add(pictureBox4.Image);
                imageList.Add(pictureBox5.Image);
                imageList.Add(pictureBox6.Image);
                imageList.Add(pictureBox7.Image);
                imageList.Add(pictureBox8.Image);
                imageList.Add(pictureBox9.Image);
                imageList.Add(pictureBox10.Image);
                imageList.Add(pictureBox11.Image);
                imageList.Add(pictureBox12.Image);
                imageList.Add(pictureBox13.Image);
                imageList.Add(pictureBox14.Image);
                imageList.Add(pictureBox15.Image);
                imageList.Add(pictureBox16.Image);

                Random rnd = new Random();
                List<Image> yeniListe = imageList.OrderBy<Image, int>((item) => rnd.Next()).ToList();

                pictureBox1.Image = yeniListe[0];
                pictureBox2.Image = yeniListe[1];
                pictureBox3.Image = yeniListe[2];
                pictureBox4.Image = yeniListe[3];
                pictureBox5.Image = yeniListe[4];
                pictureBox6.Image = yeniListe[5];
                pictureBox7.Image = yeniListe[6];
                pictureBox8.Image = yeniListe[7];
                pictureBox9.Image = yeniListe[8];
                pictureBox10.Image = yeniListe[9];
                pictureBox11.Image = yeniListe[10];
                pictureBox12.Image = yeniListe[11];
                pictureBox13.Image = yeniListe[12];
                pictureBox14.Image = yeniListe[13];
                pictureBox15.Image = yeniListe[14];
                pictureBox16.Image = yeniListe[15];

                copyImageList = yeniListe;

                if(correctPiecesCount() == 0)
                {
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    pictureBox9.Enabled = false;
                    pictureBox10.Enabled = false;
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    pictureBox13.Enabled = false;
                    pictureBox14.Enabled = false;
                    pictureBox15.Enabled = false;
                    pictureBox16.Enabled = false;
                }
                else
                {
                    pictureBox1.Enabled = true;
                    pictureBox2.Enabled = true;
                    pictureBox3.Enabled = true;
                    pictureBox4.Enabled = true;
                    pictureBox5.Enabled = true;
                    pictureBox6.Enabled = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    pictureBox9.Enabled = true;
                    pictureBox10.Enabled = true;
                    pictureBox11.Enabled = true;
                    pictureBox12.Enabled = true;
                    pictureBox13.Enabled = true;
                    pictureBox14.Enabled = true;
                    pictureBox15.Enabled = true;
                    pictureBox16.Enabled = true;
                }
                
                var lines = File.ReadAllLines(@"C:\Users\yagiz\Documents\GitHub\PuzzleGameFinal\PuzzleGame\PuzzleGame\yuksekskor.txt");
                List<int> stringList = new List<int>();
                for (int i = 0; i < lines.Length; i++)
                {
                    stringList.Add(Convert.ToInt32(lines[i]));
                }
                stringList.Sort();
                stringList.Reverse();
                foreach (var str in stringList)
                {
                    listBox1.Items.Add(str);
                }

                button17.Enabled = false;
            }
        }

        public int finalPoint(int a)
        {
            int finalPoint = 100;

            finalPoint = 100 - a * 3;

            string sPoint = finalPoint.ToString();

            DialogResult dialogResult = MessageBox.Show("Oyun bitti yüksek skor görmek için 'EVET' çıkmak için 'HAYIR' a basınız", "Oyun Bitti", MessageBoxButtons.YesNo);
          
             if (dialogResult == DialogResult.Yes)
            {
                File.AppendAllText(@"C:\Users\yagiz\Documents\GitHub\PuzzleGameFinal\PuzzleGame\PuzzleGame\yuksekskor.txt", sPoint + "\n");
                
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }

            var lines = File.ReadAllLines(@"C:\Users\yagiz\Documents\GitHub\PuzzleGameFinal\PuzzleGame\PuzzleGame\yuksekskor.txt");
            List<int> stringList = new List<int>();
            for (int i = 0; i < lines.Length; i++)
            {
                stringList.Add(Convert.ToInt32(lines[i]));
            }
            foreach (var str in stringList)
            {
                listBox1.Items.Remove(str);
            }
            
            stringList.Sort();
            stringList.Reverse();
            foreach (var str in stringList)
            {
                listBox1.Items.Add(str);
            }

            return finalPoint;

        }

        public int correctPiecesCount()
        {
            int correctPiecesCount = 0;
            if (pictureBox1.Image == imageList[0])
            {
                correctPiecesCount++;
            }
            if (pictureBox2.Image == imageList[1])
            {
                correctPiecesCount++;
            }
            if (pictureBox3.Image == imageList[2])
            {
                correctPiecesCount++;
            }
            if (pictureBox4.Image == imageList[3])
            {
                correctPiecesCount++;
            }
            if (pictureBox5.Image == imageList[4])
            {
                correctPiecesCount++;
            }
            if (pictureBox6.Image == imageList[5])
            {
                correctPiecesCount++;
            }
            if (pictureBox7.Image == imageList[6])
            {
                correctPiecesCount++;
            }
            if (pictureBox8.Image == imageList[7])
            {
                correctPiecesCount++;
            }
            if (pictureBox9.Image == imageList[8])
            {
                correctPiecesCount++;
            }
            if (pictureBox10.Image == imageList[9])
            {
                correctPiecesCount++;
            }
            if (pictureBox11.Image == imageList[10])
            {
                correctPiecesCount++;
            }
            if (pictureBox12.Image == imageList[11])
            {
                correctPiecesCount++;
            }
            if (pictureBox13.Image == imageList[12])
            {
                correctPiecesCount++;
            }
            if (pictureBox14.Image == imageList[13])
            {
                correctPiecesCount++;
            }
            if (pictureBox15.Image == imageList[14])
            {
                correctPiecesCount++;
            }
            if (pictureBox16.Image == imageList[15])
            {
                correctPiecesCount++;
            }

            return correctPiecesCount;
        }

        public Image resizeImage(int newWidth, int newHeight, string stPhotoPath)
        {
            Image imgPhoto = Image.FromFile(stPhotoPath);

            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;

            //Consider vertical pics
            if (sourceWidth < sourceHeight)
            {
                int buff = newWidth;

                newWidth = newHeight;
                newHeight = buff;
            }

            int sourceX = 0, sourceY = 0, destX = 0, destY = 0;
            float nPercent = 0, nPercentW = 0, nPercentH = 0;

            nPercentW = ((float)newWidth / (float)sourceWidth);
            nPercentH = ((float)newHeight / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((newWidth -
                          (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((newHeight -
                          (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);





            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                         imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Black);
            grPhoto.InterpolationMode =
                System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            imgPhoto.Dispose();


            return bmPhoto;
        }

        public Bitmap divide(Bitmap btmap, int x1, int y1, int x2, int y2)
        {
            Color color = new Color();
            Bitmap btTemp = new Bitmap(96, 96);
            for (int i = x1; i < x2; i++)
            {
                for (int k = y1; k < y2; k++)
                {
                    int a = i % 96;
                    int b = k % 96;
                    color = btmap.GetPixel(i, k);
                    btTemp.SetPixel(a, b, color);

                }

            }
            return btTemp;

        }

        private void form1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox2.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox2.Image;
                moveCount++;
                pictureBox2_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;
                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {final
                if (pictureBox17.Image == pictureBox2.Image)
                {
                    pictureBox2.Image = pictureBox18.Image;



                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox2.Image)
                {
                    pictureBox2.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox2_Click(sender, e);
                }
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox3.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox3.Image;
                moveCount++;
                pictureBox3_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox3.Image)
                {
                    pictureBox3.Image = pictureBox18.Image;



                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox3.Image)
                {
                    pictureBox3.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox3_Click(sender, e);
                }
            }


        }

        //private void pictureBox3_Click(object sender, EventArgs e)
        //{
        //    if (pictureBox17.Image == null && pictureBox18.Image == null)
        //    {
        //        pictureBox17.Image = pictureBox3.Image;
        //    }
        //    else if (pictureBox17.Image != null && pictureBox18.Image == null)
        //    {
        //        pictureBox18.Image = pictureBox3.Image;
        //        pictureBox3_Click(sender, e);


        //    }
        //    else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
        //    {
        //        pictureBox17.Image = null;
        //        pictureBox18.Image = null;
        //    }
        //    else if (pictureBox17.Image != null && pictureBox18.Image != null)
        //    {
        //        if (pictureBox17.Image == pictureBox3.Image)
        //        {
        //            pictureBox3.Image = pictureBox18.Image;


        //            if (pictureBox1.Image == pictureBox18.Image)
        //            {
        //                pictureBox1_Click(sender, e);
        //            }
        //            else if (pictureBox2.Image == pictureBox18.Image)
        //            {
        //                pictureBox2_Click(sender, e);
        //            }
        //            else if (pictureBox4.Image == pictureBox18.Image)
        //            {
        //                pictureBox4_Click(sender, e);
        //            }
        //            else if (pictureBox5.Image == pictureBox18.Image)
        //            {
        //                pictureBox5_Click(sender, e);
        //            }
        //            else if (pictureBox6.Image == pictureBox18.Image)
        //            {
        //                pictureBox6_Click(sender, e);
        //            }
        //            else if (pictureBox7.Image == pictureBox18.Image)
        //            {
        //                pictureBox7_Click(sender, e);
        //            }
        //            else if (pictureBox8.Image == pictureBox18.Image)
        //            {
        //                pictureBox8_Click(sender, e);
        //            }
        //            else if (pictureBox9.Image == pictureBox18.Image)
        //            {
        //                pictureBox9_Click(sender, e);
        //            }
        //            else if (pictureBox10.Image == pictureBox18.Image)
        //            {
        //                pictureBox10_Click(sender, e);
        //            }
        //            else if (pictureBox11.Image == pictureBox18.Image)
        //            {
        //                pictureBox11_Click(sender, e);
        //            }
        //            else if (pictureBox12.Image == pictureBox18.Image)
        //            {
        //                pictureBox12_Click(sender, e);
        //            }
        //            else if (pictureBox13.Image == pictureBox18.Image)
        //            {
        //                pictureBox13_Click(sender, e);
        //            }
        //            else if (pictureBox14.Image == pictureBox18.Image)
        //            {
        //                pictureBox14_Click(sender, e);
        //            }
        //            else if (pictureBox15.Image == pictureBox18.Image)
        //            {
        //                pictureBox15_Click(sender, e);
        //            }
        //            else if (pictureBox16.Image == pictureBox18.Image)
        //            {
        //                pictureBox16_Click(sender, e);
        //            }

        //            pictureBox18.Image = pictureBox17.Image;
        //        }
        //        else if (pictureBox18.Image == pictureBox3.Image)
        //        {
        //            pictureBox3.Image = pictureBox17.Image;


        //            if (pictureBox1.Image == pictureBox17.Image)
        //            {
        //                pictureBox1_Click(sender, e);
        //            }
        //            else if (pictureBox2.Image == pictureBox17.Image)
        //            {
        //                pictureBox2_Click(sender, e);
        //            }
        //            else if (pictureBox4.Image == pictureBox17.Image)
        //            {
        //                pictureBox4_Click(sender, e);
        //            }
        //            else if (pictureBox5.Image == pictureBox17.Image)
        //            {
        //                pictureBox5_Click(sender, e);
        //            }
        //            else if (pictureBox6.Image == pictureBox17.Image)
        //            {
        //                pictureBox6_Click(sender, e);
        //            }
        //            else if (pictureBox7.Image == pictureBox17.Image)
        //            {
        //                pictureBox7_Click(sender, e);
        //            }
        //            else if (pictureBox8.Image == pictureBox17.Image)
        //            {
        //                pictureBox8_Click(sender, e);
        //            }
        //            else if (pictureBox9.Image == pictureBox17.Image)
        //            {
        //                pictureBox9_Click(sender, e);
        //            }
        //            else if (pictureBox10.Image == pictureBox17.Image)
        //            {
        //                pictureBox10_Click(sender, e);
        //            }
        //            else if (pictureBox11.Image == pictureBox17.Image)
        //            {
        //                pictureBox11_Click(sender, e);
        //            }
        //            else if (pictureBox12.Image == pictureBox17.Image)
        //            {
        //                pictureBox12_Click(sender, e);
        //            }
        //            else if (pictureBox13.Image == pictureBox17.Image)
        //            {
        //                pictureBox13_Click(sender, e);
        //            }
        //            else if (pictureBox14.Image == pictureBox17.Image)
        //            {
        //                pictureBox14_Click(sender, e);
        //            }
        //            else if (pictureBox15.Image == pictureBox17.Image)
        //            {
        //                pictureBox15_Click(sender, e);
        //            }
        //            else if (pictureBox16.Image == pictureBox17.Image)
        //            {
        //                pictureBox16_Click(sender, e);
        //            }

        //            pictureBox17.Image = pictureBox18.Image;
        //            pictureBox3_Click(sender, e);
        //        }
        //    }


        //}

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox4.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox4.Image;
                moveCount++;
                pictureBox4_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {

                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox4.Image)
                {
                    pictureBox4.Image = pictureBox18.Image;



                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox4.Image)
                {
                    pictureBox4.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox4_Click(sender, e);

                }
            }


        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox5.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox5.Image;
                moveCount++;
                pictureBox5_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox5.Image)
                {
                    pictureBox5.Image = pictureBox18.Image;


                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox5.Image)
                {
                    pictureBox5.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox5_Click(sender, e);
                }
            }


        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox6.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox6.Image;
                moveCount++;
                pictureBox6_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox6.Image)
                {
                    pictureBox6.Image = pictureBox18.Image;


                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox6.Image)
                {
                    pictureBox6.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox6_Click(sender, e);
                }
            }


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox7.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox7.Image;
                moveCount++;
                pictureBox7_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox7.Image)
                {
                    pictureBox7.Image = pictureBox18.Image;


                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox7.Image)
                {
                    pictureBox7.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox7_Click(sender, e);
                }
            }


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox8.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox8.Image;
                moveCount++;
                pictureBox8_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox8.Image)
                {
                    pictureBox8.Image = pictureBox18.Image;


                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox8.Image)
                {
                    pictureBox8.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox8_Click(sender, e);
                }
            }


        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox9.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox9.Image;
                moveCount++;
                pictureBox9_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox9.Image)
                {
                    pictureBox9.Image = pictureBox18.Image;


                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox9.Image)
                {
                    pictureBox9.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox9_Click(sender, e);
                }
            }


        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox10.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox10.Image;
                moveCount++;
                pictureBox10_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox10.Image)
                {
                    pictureBox10.Image = pictureBox18.Image;


                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox10.Image)
                {
                    pictureBox10.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox10_Click(sender, e);
                }
            }


        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox11.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox11.Image;
                moveCount++;
                pictureBox11_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox11.Image)
                {
                    pictureBox11.Image = pictureBox18.Image;


                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox11.Image)
                {
                    pictureBox11.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox11_Click(sender, e);
                }
            }


        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox12.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox12.Image;
                moveCount++;
                pictureBox12_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox12.Image)
                {
                    pictureBox12.Image = pictureBox18.Image;


                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox12.Image)
                {
                    pictureBox12.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox12_Click(sender, e);
                }
            }


        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox13.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox13.Image;
                moveCount++;
                pictureBox13_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox13.Image)
                {
                    pictureBox13.Image = pictureBox18.Image;


                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox13.Image)
                {
                    pictureBox13.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox13_Click(sender, e);
                }
            }


        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox14.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox14.Image;
                moveCount++;
                pictureBox14_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox14.Image)
                {
                    pictureBox14.Image = pictureBox18.Image;


                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox14.Image)
                {
                    pictureBox14.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox14_Click(sender, e);
                }
            }


        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox15.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox15.Image;
                moveCount++;
                pictureBox15_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox15.Image)
                {
                    pictureBox15.Image = pictureBox18.Image;


                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox15.Image)
                {
                    pictureBox15.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox15_Click(sender, e);
                }
            }


        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox16.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox16.Image;
                moveCount++;
                pictureBox16_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;

                if (correctPiecesCount() == 16)
                {
                    finalPoint(moveCount);
                }
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox16.Image)
                {
                    pictureBox16.Image = pictureBox18.Image;


                    if (pictureBox1.Image == pictureBox18.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox16.Image)
                {
                    pictureBox16.Image = pictureBox17.Image;


                    if (pictureBox1.Image == pictureBox17.Image)
                    {
                        pictureBox1_Click(sender, e);
                    }
                    else if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }

                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox16_Click(sender, e);
                }
            }


        }




        //Main Picture Box
        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == null && pictureBox18.Image == null)
            {
                pictureBox17.Image = pictureBox1.Image;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image == null)
            {
                pictureBox18.Image = pictureBox1.Image;
                moveCount++;
                pictureBox1_Click(sender, e);


            }
            else if (pictureBox17.Image == pictureBox18.Image && pictureBox17.Image != null)
            {
                pictureBox17.Image = null;
                pictureBox18.Image = null;
            }
            else if (pictureBox17.Image != null && pictureBox18.Image != null)
            {
                if (pictureBox17.Image == pictureBox1.Image)
                {
                    pictureBox1.Image = pictureBox18.Image;

                    if (pictureBox2.Image == pictureBox18.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox18.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox18.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox18.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox18.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox18.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox18.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox18.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox18.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox18.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox18.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox18.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox18.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox18.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox18.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }

                    pictureBox18.Image = pictureBox17.Image;
                }
                else if (pictureBox18.Image == pictureBox1.Image)
                {
                    pictureBox1.Image = pictureBox17.Image;

                    if (pictureBox2.Image == pictureBox17.Image)
                    {
                        pictureBox2_Click(sender, e);
                    }
                    else if (pictureBox3.Image == pictureBox17.Image)
                    {
                        pictureBox3_Click(sender, e);
                    }
                    else if (pictureBox4.Image == pictureBox17.Image)
                    {
                        pictureBox4_Click(sender, e);
                    }
                    else if (pictureBox5.Image == pictureBox17.Image)
                    {
                        pictureBox5_Click(sender, e);
                    }
                    else if (pictureBox6.Image == pictureBox17.Image)
                    {
                        pictureBox6_Click(sender, e);
                    }
                    else if (pictureBox7.Image == pictureBox17.Image)
                    {
                        pictureBox7_Click(sender, e);
                    }
                    else if (pictureBox8.Image == pictureBox17.Image)
                    {
                        pictureBox8_Click(sender, e);
                    }
                    else if (pictureBox9.Image == pictureBox17.Image)
                    {
                        pictureBox9_Click(sender, e);
                    }
                    else if (pictureBox10.Image == pictureBox17.Image)
                    {
                        pictureBox10_Click(sender, e);
                    }
                    else if (pictureBox11.Image == pictureBox17.Image)
                    {
                        pictureBox11_Click(sender, e);
                    }
                    else if (pictureBox12.Image == pictureBox17.Image)
                    {
                        pictureBox12_Click(sender, e);
                    }
                    else if (pictureBox13.Image == pictureBox17.Image)
                    {
                        pictureBox13_Click(sender, e);
                    }
                    else if (pictureBox14.Image == pictureBox17.Image)
                    {
                        pictureBox14_Click(sender, e);
                    }
                    else if (pictureBox15.Image == pictureBox17.Image)
                    {
                        pictureBox15_Click(sender, e);
                    }
                    else if (pictureBox16.Image == pictureBox17.Image)
                    {
                        pictureBox16_Click(sender, e);
                    }


                    pictureBox17.Image = pictureBox18.Image;
                    pictureBox1_Click(sender, e);
                }
            }

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam hamle sayısı=" + moveCount);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            }
    }
    }

