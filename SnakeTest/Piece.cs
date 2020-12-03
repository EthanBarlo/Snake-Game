using System.Windows.Forms;

namespace SnakeTest
{
    // Generic piece class, This is esentially the basic game piece, or Block
    class Piece
    {
        // Attribute
        protected PictureBox entity;

        // Constructors
        public Piece(Panel panel)
        {
            entity = new PictureBox();
            entity.BackColor = System.Drawing.Color.Transparent;
            entity.Width = 20;
            entity.Height = 20;
            panel.Controls.Add(entity);
        }
        public Piece(PictureBox pBox)
        {
            entity = pBox;
        }

        // Operations
        public int GetX()
        {
            return entity.Location.X;
        }
        public int GetY()
        {
            return entity.Location.Y;
        }

        public void remove(Panel panel)
        {
            panel.Controls.Remove(entity);
        }
    }
}
