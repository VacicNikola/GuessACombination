using GuessACombinationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GuessACombination
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game game;
        private bool stop;      // ova vrednost ce biti true kada brojac bude 5/9/13/17/21. Funkcija ovog booleana je da zabrani da igrac pritiska dugmad ako vec ima 4 znaka spremna za testiranje.

        public MainWindow()
        {
            InitializeComponent();
            game = new Game();
            stop = false;
        }

        private void jokerButton_Click(object sender, RoutedEventArgs e)
        {
            if (stop == false)
            {
                ButtonsLogic("/Images/joker.png");
                game.Add(Types.Joker);
            }
            if (game.counter == 5 || game.counter == 9 || game.counter == 13 || game.counter == 17 || game.counter == 21)
                stop = true;
        }


        private void starButton_Click(object sender, RoutedEventArgs e)
        {
            if (stop == false)
            {
                ButtonsLogic("/Images/star.png");
                game.Add(Types.Star);
            }
            if (game.counter == 5 || game.counter == 9 || game.counter == 13 || game.counter == 17 || game.counter == 21)
                stop = true;
        }

        private void heartsButton_Click(object sender, RoutedEventArgs e)
        {
            if (stop == false)
            {
                ButtonsLogic("/Images/hearts.png");
                game.Add(Types.Hearts);
            }
            if (game.counter == 5 || game.counter == 9 || game.counter == 13 || game.counter == 17 || game.counter == 21)
                stop = true;
        }

        private void diamondsButton_Click(object sender, RoutedEventArgs e)
        {
            if (stop == false)
            {
                ButtonsLogic("/Images/diamonds.png");
                game.Add(Types.Diamonds);
            }
            if (game.counter == 5 || game.counter == 9 || game.counter == 13 || game.counter == 17 || game.counter == 21)
                stop = true;
        }

        private void spadesButton_Click(object sender, RoutedEventArgs e)
        {
            if (stop == false)
            {
                ButtonsLogic("/Images/spades.png");
                game.Add(Types.Spades);
            }
            if (game.counter == 5 || game.counter == 9 || game.counter == 13 || game.counter == 17 || game.counter == 21)
                stop = true;
        }

        private void clubsButton_Click(object sender, RoutedEventArgs e)
        {
            if (stop == false)
            {
                ButtonsLogic("/Images/clubs.png");
                game.Add(Types.Clubs);
            }
            if (game.counter == 5 || game.counter == 9 || game.counter == 13 || game.counter == 17 || game.counter == 21)
                stop = true;
        }

        private void ButtonsLogic(string v)
        {
            switch (game.counter) {
                case 1: square1.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 2: square2.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 3: square3.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 4: square4.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 5: square5.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 6: square6.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 7: square7.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 8: square8.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 9: square9.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 10: square10.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 11: square11.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 12: square12.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 13: square13.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 14: square14.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 15: square15.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 16: square16.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 17: square17.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 18: square18.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 19: square19.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 20: square20.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 21: square21.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 22: square22.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 23: square23.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;
                case 24: square24.Source = new BitmapImage(new Uri($"{v}", UriKind.Relative)); break;

                default: break;
            }
        }
        

        // delete radi
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            game.Delete();

            stop = false;
            
            switch (game.counter)
            {
                case 1: square1.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 2: square2.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 3: square3.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 4: square4.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 5: square5.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 6: square6.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 7: square7.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 8: square8.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 9: square9.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 10: square10.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 11: square11.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 12: square12.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 13: square13.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 14: square14.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 15: square15.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 16: square16.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 17: square17.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 18: square18.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 19: square19.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 20: square20.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 21: square21.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 22: square22.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 23: square23.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;
                case 24: square24.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative)); break;

                default: break;
            }


        }

        // reset radi
        private void reset_Click(object sender, RoutedEventArgs e)
        {
            square1.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square2.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square3.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square4.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square5.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square6.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square7.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square8.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square9.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square10.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square11.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square12.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square13.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square14.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square15.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square16.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square17.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square18.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square19.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square20.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square21.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square22.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square23.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            square24.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));

            circle1.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle2.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle3.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle4.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle5.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle6.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle7.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle8.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle9.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle10.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle11.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle12.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle13.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle14.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle15.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle16.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle17.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle18.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle19.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle20.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle21.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle22.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle23.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));
            circle24.Source = new BitmapImage(new Uri("/Images/Square.png", UriKind.Relative));



            game = new Game();
            stop = false;
        }



        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            string output = "";

            if (game.attemptSize())
            {
                stop = false;
                output = game.checkAttempt();
                paintCircles(output);
                if (output != "RRRR" && game.counter == 25)
                {
                    game.counter = 26;
                    MessageBox.Show("Try again", "Tough Luck!", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }

        }

        private void paintCircles(string output)
        {
            if (game.counter == 5)
            {
                if (output[0] == 'R')
                    circle1.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[0] == 'Y')
                    circle1.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[1] == 'R')
                    circle2.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[1] == 'Y')
                    circle2.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[2] == 'R')
                    circle3.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[2] == 'Y')
                    circle3.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[3] == 'R')
                    circle4.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[3] == 'Y')
                    circle4.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

            }

            else if (game.counter == 9)
            {
                if (output[0] == 'R')
                    circle5.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[0] == 'Y')
                    circle5.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[1] == 'R')
                    circle6.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[1] == 'Y')
                    circle6.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[2] == 'R')
                    circle7.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[2] == 'Y')
                    circle7.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[3] == 'R')
                    circle8.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[3] == 'Y')
                    circle8.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

            }

            else if (game.counter == 13)
            {
                if (output[0] == 'R')
                    circle9.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[0] == 'Y')
                    circle9.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[1] == 'R')
                    circle10.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[1] == 'Y')
                    circle10.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[2] == 'R')
                    circle11.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[2] == 'Y')
                    circle11.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[3] == 'R')
                    circle12.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[3] == 'Y')
                    circle12.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

            }

            else if (game.counter == 17)
            {
                if (output[0] == 'R')
                    circle13.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[0] == 'Y')
                    circle13.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[1] == 'R')
                    circle14.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[1] == 'Y')
                    circle14.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[2] == 'R')
                    circle15.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[2] == 'Y')
                    circle15.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[3] == 'R')
                    circle16.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[3] == 'Y')
                    circle16.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

            }

            else if (game.counter == 21)
            {
                if (output[0] == 'R')
                    circle17.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[0] == 'Y')
                    circle17.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[1] == 'R')
                    circle18.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[1] == 'Y')
                    circle18.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[2] == 'R')
                    circle19.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[2] == 'Y')
                    circle19.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[3] == 'R')
                    circle20.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[3] == 'Y')
                    circle20.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

            }


            else {

                if (output[0] == 'R')
                    circle21.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[0] == 'Y')
                    circle21.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[1] == 'R')
                    circle22.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[1] == 'Y')
                    circle22.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[2] == 'R')
                    circle23.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[2] == 'Y')
                    circle23.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

                if (output[3] == 'R')
                    circle24.Source = new BitmapImage(new Uri("/Images/Red.png", UriKind.Relative));
                else if (output[3] == 'Y')
                    circle24.Source = new BitmapImage(new Uri("/Images/Yellow.png", UriKind.Relative));
                else return;

            }

            if (output == "RRRR")
            {
                game.counter = 26;
                MessageBox.Show("You guessed it!", "Congratulations!", MessageBoxButton.OK, MessageBoxImage.Information);
                
            }

            


        }
    }
}
