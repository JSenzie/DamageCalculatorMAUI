using DamageCalculator;

namespace DamageCalculatorMAUI
{
    public partial class MainPage : ContentPage
    {
        SwordDamage swordDamage = new();

        public MainPage()
        {
            InitializeComponent();
            swordDamage.Magic = (Magic.IsChecked);
            swordDamage.Flaming = (Flaming.IsChecked);
            RollDice();
        }

        private void RollDice()
        {
            swordDamage.Roll = Random.Shared.Next(1, 19);
            DisplayDamage();
        }

        private void DisplayDamage() {
            Damage.Text = $"Rolled {swordDamage.Roll} for {swordDamage.Damage} HP";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            RollDice();
        }

        private void Flaming_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            swordDamage.Flaming = (e.Value);
            DisplayDamage();
        }

        private void Magic_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            swordDamage.Magic = (e.Value);
            DisplayDamage();
        }
    }

}
