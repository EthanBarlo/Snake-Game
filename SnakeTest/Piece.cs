using System.Windows.Forms;

namespace SnakeTest
{
    // Generic piece class, This is esentially the basic game piece, or Block
    class Piece
    {
        protected Label entity;
        public Piece(Panel panel)
        {
            entity = new Label();
            entity.BackColor = System.Drawing.Color.Transparent;
            entity.Width = 20;
            entity.Height = 20;
            panel.Controls.Add(entity);
        }

        public Piece(Label label)
        {
            entity = label;
        }

        public void remove(Panel panel)
        {
            panel.Controls.Remove(entity);
        }
    }
}
