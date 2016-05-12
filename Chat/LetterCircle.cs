﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Chat
{
    public class LetterCircle
    {
        public static readonly int RADIUS = 26;
        public char Letter { get; set; }

        public Point Center { get; set; }
        private int Height;
        public bool IsHit { get; set; }

        public LetterCircle(Random random, int width, int height)
        {
            Letter = (char)((int)'A' + random.Next(26));
            int x = random.Next(RADIUS, width - (2 * RADIUS));
            int y = RADIUS;
            Center = new Point(x, y);
            this.Height = height;
            IsHit = false;
        }

        public void Draw(Graphics g)
        {
            if (IsHit)
            {
                g.FillEllipse(Brushes.DarkRed, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            }
            else
            {
                g.FillEllipse(Brushes.LightBlue, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            }
            Font f = new Font("Arial", 24);
            g.DrawString(string.Format("{0}", Letter), f, Brushes.Black, Center.X - 16, Center.Y - 15);
            f.Dispose();
        }

        public void Move()
        {
            Center = new Point(Center.X, Center.Y + 10);
        }

        public bool ShouldDie()
        {
            return Center.Y > Height - 25;
        }
    }
}
