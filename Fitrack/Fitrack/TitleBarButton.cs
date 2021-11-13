using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Fitrack
{
    class TitleBarButton : PictureBox
    {
        private Color unhoverColor;

        [Category("Colors")]
        public Color UnhoverColor
        {
            get { return this.unhoverColor; }
            set { this.unhoverColor = value; }
        }

        private Color hoverColor;

        [Category("Colors")]
        public Color HoverColor
        {
            get { return this.hoverColor; }
            set { this.hoverColor = value; }
        }

        private Image hoverImage;

        [Category("Images")]
        public Image HoverImage
        {
            get { return this.hoverImage; }
            set { this.hoverImage = value; }
        }

        private Image unhoverImage;

        [Category("Images")]
        public Image UnhoverImage
        {
            get { return this.unhoverImage; }
            set { this.unhoverImage = value; }
        }

        public TitleBarButton()
        {
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Dock = DockStyle.Right;            
            this.Size = new Size(25, 25);
            this.Padding = new Padding(5);
            this.Cursor = Cursors.Hand;
        }
    }
}
