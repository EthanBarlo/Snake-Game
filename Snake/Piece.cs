using System.Windows.Forms;

namespace Snake
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
            entity.Width = GameSettings.CellSize;
            entity.Height = GameSettings.CellSize;
            entity.SizeMode = PictureBoxSizeMode.StretchImage;
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

        public void Remove(Panel panel)
        {
            panel.Controls.Remove(entity);
        }
    }
}
