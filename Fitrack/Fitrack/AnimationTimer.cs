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
    class AnimationTimer : Timer
    {
        public Color startColor;
        public Color targetColor;
        public PictureBox currentButton;
        public float percentage;
        public float reversePercentage;

        public AnimationTimer()
        {

        }

        public void Animate()
        {
            if (currentButton == null || targetColor == null) { return; }

            if (currentButton.BackColor != targetColor)
            {
                currentButton.BackColor = Color.FromArgb(
                    ValueToTarget(startColor.R, targetColor.R),
                    ValueToTarget(startColor.G, targetColor.G),
                    ValueToTarget(startColor.B, targetColor.B));

                percentage += 0.1f;

                if (percentage > 1) { percentage = 1; }

                else if (percentage < 0) { percentage = 0; }
            }

            else { return; }
        }

        public void Reset()
        {
            currentButton = null;
            percentage = 0;
            reversePercentage = 1;
        }

        public int ValueToTarget(int value, int target)
        {
            if (value == target) { return value; }

            else if (value > target) 
            {
                value = (int)Lerp(value, target, percentage);
            }

            else 
            {
                value = (int) Lerp(value, target, percentage);
            }

            return value;
        }

        float Lerp(float firstFloat, float secondFloat, float by)
        {
            return firstFloat * (1 - by) + secondFloat * by;
        }
    }
}
