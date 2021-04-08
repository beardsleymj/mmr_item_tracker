using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using mm_item_tracker.Properties;

namespace mm_item_tracker
{
    class Item : PictureBox
    {
        private Image[] images;
        private Image grayImage = null;
        private Item pairedItem = null;
        private int currentImage = -1; // gray
        PictureBox songCheckMark = null;

        public Item(Image[] images, int x, int y, PictureBox checkMark = null, bool startingItem = false, bool startingCheckMark = false)
        {
            this.images = images;
            grayImage = images[0].ToGrayScale();
            this.Location = new Point(x, y);
            this.Size = images[0].Size;
            this.BackgroundImage = grayImage;
            this.BackColor = Color.Transparent;
            this.songCheckMark = checkMark;
            if (startingItem)
            {
                this.BackgroundImage = images[0];
                currentImage = 0;
            }
            if (checkMark != null)
            {
                checkMark.Location = new Point(this.Location.X + 31, this.Location.Y - 3);
                if (startingCheckMark)
                    songCheckMark.Visible = true;
                checkMark.Enabled = false;
            }
        }

        public Item PairedItem
        {
            get { return pairedItem; }
            set { pairedItem = value; }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                grayImage.Dispose();
            }

            base.Dispose(disposing);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (songCheckMark != null)
            {
                updateSong(e);
            }
            else if (images.Length == 1)
            {
                updateItem();
            }
            else
            {
                updateProgressiveItem(e);
                if (pairedItem != null)
                    pairedItem.updateProgressiveItem(e);
            }
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            OnMouseClick(e);
        }

        private void updateSong(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (this.BackgroundImage == images[0])
                        this.BackgroundImage = grayImage;
                    else if (this.BackgroundImage == grayImage)
                        this.BackgroundImage = images[0];
                    break;
                case MouseButtons.Right:
                    if (songCheckMark.Visible == true)
                        songCheckMark.Visible = false;
                    else
                        songCheckMark.Visible = true;
                break;
            }
        }

        private void updateItem()
        {
            if (this.BackgroundImage == images[0])
                this.BackgroundImage = grayImage;
            else if (this.BackgroundImage == grayImage)
                this.BackgroundImage = images[0];
        }

        private void updateProgressiveItem(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (currentImage < images.Length - 1)
                        this.BackgroundImage = images[++currentImage];
                break;
                case MouseButtons.Right:
                    if (currentImage > 0)
                        this.BackgroundImage = images[--currentImage];
                    else
                    {
                        this.BackgroundImage = grayImage;
                        currentImage = -1;
                    }
                break;
            }
        }
    }

    public static class ImageExtensions
    {
        static ColorMatrix grayMatrix = new ColorMatrix(new float[][]
        {
            new float[] { .2f, .2f, .2f, 0, 0 },
            new float[] { .2f, .2f, .2f, 0, 0 },
            new float[] { .2f, .2f, .2f, 0, 0 },
            new float[] { 0, 0, 0, 1, 0 },
            new float[] { 0, 0, 0, 0, 1 }
        });

        public static Bitmap ToGrayScale(this Image source)
        {
            var grayImage = new Bitmap(source.Width, source.Height, source.PixelFormat);
            grayImage.SetResolution(source.HorizontalResolution, source.VerticalResolution);

            using (var g = Graphics.FromImage(grayImage))
            using (var attributes = new ImageAttributes())
            {
                attributes.SetColorMatrix(grayMatrix);
                g.DrawImage(source, new Rectangle(0, 0, source.Width, source.Height),
                            0, 0, source.Width, source.Height, GraphicsUnit.Pixel, attributes);
                return grayImage;
            }
        }
    }
}
