using System.Configuration;

namespace Ippo_PunchOut_Game
{
    public partial class Ippo_PunchOut_Game : Form
    {

        bool playerBlock = false;
        bool enemyBlock = false;
        Random random = new Random();

        int enemySpeed = 5;
        int index = 0;
        int playerHealth = 100;
        int enemyHealth = 100;

        int boxerCount = 0;
        int playerCount = 0;

        List<string> enemyAttack = new List<string> { "left", "right", "block" };


        public Ippo_PunchOut_Game()
        {
            InitializeComponent();

            ResetGame();

        }

        private void BoxerAttackTimerEvent(object sender, EventArgs e)
        {

            index = random.Next(0, enemyAttack.Count);

            switch (enemyAttack[index].ToString())
            {

                case "left":
                    Boxer.Image = Properties.Resources.enemy_punch1;
                    enemyBlock = false;
                    if (Boxer.Bounds.IntersectsWith(Player.Bounds) && playerBlock == false) { playerHealth -= 5; }
                    break;

                case "right":
                    Boxer.Image = Properties.Resources.enemy_punch2;
                    enemyBlock = false;
                    if (Boxer.Bounds.IntersectsWith(Player.Bounds) && playerBlock == false) { playerHealth -= 5; }
                    break;

                case "block":
                    Boxer.Image = Properties.Resources.enemy_block;
                    enemyBlock = true;
                    break;



            }
        }

        private void BoxerMoveTimerEvent(object sender, EventArgs e)
        {

            //both health bar setup here

            if (playerHealth > 1)
            {
                PlayerHealthBar.Value = playerHealth;


            }

            if (enemyHealth > 1)
            {

                BoxerHealthBar.Value = enemyHealth;
            }


            // movements


            Boxer.Left += enemySpeed;

            if (Boxer.Left > 430)
            {

                enemySpeed = -5;


            }

            if (Boxer.Left < 220)
            {

                enemySpeed = 5;

            }


            // check for the game end scenario

            if (enemyHealth < 1)
            {
                BoxerMoveTimer.Stop();
                BoxerAttackTimer.Stop();
                MessageBox.Show("Ippo Wins , Click Ok to Play Again", "Rahul Says");
                playerCount++;
                PlayerWinCount.Text = playerCount.ToString();
                ResetGame();
            }

            if (playerHealth < 1)
            {
                BoxerMoveTimer.Stop();
                BoxerAttackTimer.Stop();
                MessageBox.Show("Takamura Wins ,Click Ok to Play Again", "Rahul Says");
                boxerCount++;
                BoxerWinCount.Text = boxerCount.ToString();
                ResetGame();
            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Player.Image = Properties.Resources.boxer_left_punch;
                playerBlock = false;


                if (Player.Bounds.IntersectsWith(Boxer.Bounds) && enemyBlock == false)
                {
                    enemyHealth -= 5;
                }
            }


            if (e.KeyCode == Keys.Right)
            {
                Player.Image = Properties.Resources.boxer_right_punch;
                playerBlock = false;

                if (Player.Bounds.IntersectsWith(Boxer.Bounds) && enemyBlock == false)
                {
                    enemyHealth -= 5;
                }

            }


            if (e.KeyCode == Keys.Down)
            {
                Player.Image = Properties.Resources.boxer_block;
                playerBlock = true;

            }



        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            Player.Image = Properties.Resources.boxer_stand;
            playerBlock = false;

        }


        private void ResetGame()
        {
            BoxerMoveTimer.Start();
            BoxerAttackTimer.Start();
            playerHealth = 100;
            enemyHealth = 100;
            Boxer.Left = 400;


        }

        private void BoxerWinCount_Click(object sender, EventArgs e)
        {

        }

        private void PlayerWinCount_Click(object sender, EventArgs e)
        {

        }

        private void GameStarts_Click(object sender, EventArgs e)
        {
            ResetGame();

        }

        private void ResetGames_Click(object sender, EventArgs e)
        {
            playerCount = 0;
            boxerCount = 0;

            ResetGame();
        }
    }
}