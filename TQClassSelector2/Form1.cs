namespace TQClassSelector2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "Spirit" && comboBox2.Text == "Spirit")
            {
                label3.Text = "Theurgist";
                label3.Visible = true;
                pictureBox1.Visible = true;
            }
            if (comboBox1.Text == "Spirit" && comboBox2.Text == "Nature")
            {
                label3.Text = "Soothsayer";
                label3.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            if (comboBox1.Text == "Nature" && comboBox2.Text == "Spirit")
            {
                label3.Text = "Soothsayer";
                label3.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            if (comboBox1.Text == "Nature" && comboBox2.Text == "Nature")
            {
                label3.Text = "Wanderer";
                label3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            if (comboBox1.Text == "Spirit" && comboBox2.Text == "Rogue")
            {
                label3.Text = "Warlock";
                label3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Visible = false;
            }
            if (comboBox1.Text == "Rogue" && comboBox2.Text == "Spirit")
            {
                label3.Text = "Warlock";
                label3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Visible = false;
            }
            if (comboBox1.Text == "Nature" && comboBox2.Text == "Rogue")
            {
                label3.Text = "Illusionist";
                label3.Visible = true;
                pictureBox7.Visible = true;
                pictureBox4.Visible = false;
            }
            if (comboBox1.Text == "Rogue" && comboBox2.Text == "Nature")
            {
                label3.Text = "Illusionist";
                label3.Visible = true;
                pictureBox7.Visible = true;
                pictureBox4.Visible = false;
            }
            if (comboBox1.Text == "Rogue" && comboBox2.Text == "Rogue")
            {
                label3.Text = "Rogue";
                label3.Visible = true;
                pictureBox8.Visible = true;
                pictureBox7.Visible = false;
            }
            if (comboBox1.Text == "Rogue" && comboBox2.Text == "Rogue")
            {
                label3.Text = "Rogue";
                label3.Visible = true;
                pictureBox8.Visible = true;
                pictureBox7.Visible = false;
            }
            if (comboBox1.Text == "Rogue" && comboBox2.Text == "Hunting")
            {
                label3.Text = "Brigand";
                label3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox8.Visible = false;
            }
            if (comboBox1.Text == "Hunting" && comboBox2.Text == "Rogue")
            {
                label3.Text = "Brigand";
                label3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox8.Visible = false;
            }
            if (comboBox1.Text == "Hunting" && comboBox2.Text == "Hunting")
            {
                label3.Text = "Hunter";
                label3.Visible = true;
                pictureBox11.Visible = true;
                pictureBox10.Visible = false;
            }
            if (comboBox1.Text == "Spirit" && comboBox2.Text == "Hunting")
            {
                label3.Text = "Bone Charmer";
                label3.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = false;
            }
            if (comboBox1.Text == "Hunting" && comboBox2.Text == "Spirit")
            {
                label3.Text = "Bone Charmer";
                label3.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = false;
            }
            if (comboBox1.Text == "Hunting" && comboBox2.Text == "Nature")
            {
                label3.Text = "Ranger";
                label3.Visible = true;
                pictureBox13.Visible = true;
                pictureBox12.Visible = false;
            }
            if (comboBox1.Text == "Nature" && comboBox2.Text == "Hunting")
            {
                label3.Text = "Ranger";
                label3.Visible = true;
                pictureBox13.Visible = true;
                pictureBox12.Visible = false;
            }
            if (comboBox1.Text == "Spirit" && comboBox2.Text == "Storm")
            {
                label3.Text = "Oracle";
                label3.Visible = true;
                pictureBox14.Visible = true;
            }
            if (comboBox1.Text == "Storm" && comboBox2.Text == "Spirit")
            {
                label3.Text = "Oracle";
                label3.Visible = true;
                pictureBox14.Visible = true;
            }
            if (comboBox1.Text == "Nature" && comboBox2.Text == "Storm")
            {
                label3.Text = "Druid";
                label3.Visible = true;
                pictureBox15.Visible = true;
            }
            if (comboBox1.Text == "Storm" && comboBox2.Text == "Nature")
            {
                label3.Text = "Druid";
                label3.Visible = true;
                pictureBox15.Visible = true;
            }
            if (comboBox1.Text == "Rogue" && comboBox2.Text == "Storm")
            {
                label3.Text = "Sorcerer";
                label3.Visible = true;
                pictureBox16.Visible = true;
            }
            if (comboBox1.Text == "Storm" && comboBox2.Text == "Rogue")
            {
                label3.Text = "Sorcerer";
                label3.Visible = true;
                pictureBox16.Visible = true;
            }
            if (comboBox1.Text == "Hunting" && comboBox2.Text == "Storm")
            {
                label3.Text = "Sage";
                label3.Visible = true;
                pictureBox17.Visible = true;
            }
            if (comboBox1.Text == "Storm" && comboBox2.Text == "Hunting")
            {
                label3.Text = "Sage";
                label3.Visible = true;
                pictureBox17.Visible = true;
            }
            if (comboBox1.Text == "Storm" && comboBox2.Text == "Storm")
            {
                label3.Text = "Stormcaller";
                label3.Visible = true;
                pictureBox18.Visible = true;
            }
            if (comboBox1.Text == "Spirit" && comboBox2.Text == "Earth")
            {
                label3.Text = "Conjurer";
                label3.Visible = true;
                pictureBox19.Visible = true;
            }
            if (comboBox1.Text == "Earth" && comboBox2.Text == "Spirit")
            {
                label3.Text = "Conjurer";
                label3.Visible = true;
                pictureBox19.Visible = true;
            }
            if (comboBox1.Text == "Nature" && comboBox2.Text == "Earth")
            {
                label3.Text = "Summoner";
                label3.Visible = true;
                pictureBox20.Visible = true;
            }
            if (comboBox1.Text == "Earth" && comboBox2.Text == "Nature")
            {
                label3.Text = "Summoner";
                label3.Visible = true;
                pictureBox20.Visible = true;
            }
            if (comboBox1.Text == "Rogue" && comboBox2.Text == "Earth")
            {
                label3.Text = "Magician";
                label3.Visible = true;
                pictureBox21.Visible = true;
            }
            if (comboBox1.Text == "Earth" && comboBox2.Text == "Rogue")
            {
                label3.Text = "Magician";
                label3.Visible = true;
                pictureBox21.Visible = true;
            }
            if (comboBox1.Text == "Hunting" && comboBox2.Text == "Earth")
            {
                label3.Text = "Avenger";
                label3.Visible = true;
                pictureBox22.Visible = true;
            }
            if (comboBox1.Text == "Earth" && comboBox2.Text == "Hunting")
            {
                label3.Text = "Avenger";
                label3.Visible = true;
                pictureBox22.Visible = true;
            }
            if (comboBox1.Text == "Storm" && comboBox2.Text == "Earth")
            {
                label3.Text = "Elementalist";
                label3.Visible = true;
                pictureBox23.Visible = true;
            }
            if (comboBox1.Text == "Earth" && comboBox2.Text == "Storm")
            {
                label3.Text = "Elementalist";
                label3.Visible = true;
                pictureBox23.Visible = true;
            }
            if (comboBox1.Text == "Earth" && comboBox2.Text == "Earth")
            {
                label3.Text = "Pyromancer";
                label3.Visible = true;
                pictureBox24.Visible = true;
            }
            if (comboBox1.Text == "Spirit" && comboBox2.Text == "Defense")
            {
                label3.Text = "Spellbinder";
                label3.Visible = true;
                pictureBox25.Visible = true;
            }
            if (comboBox1.Text == "Defense" && comboBox2.Text == "Spirit")
            {
                label3.Text = "Spellbinder";
                label3.Visible = true;
                pictureBox25.Visible = true;
            }
            if (comboBox1.Text == "Nature" && comboBox2.Text == "Defense")
            {
                label3.Text = "Guardian";
                label3.Visible = true;
                pictureBox26.Visible = true;
            }
            if (comboBox1.Text == "Defense" && comboBox2.Text == "Nature")
            {
                label3.Text = "Guardian";
                label3.Visible = true;
                pictureBox26.Visible = true;
            }
            if (comboBox1.Text == "Rogue" && comboBox2.Text == "Defense")
            {
                label3.Text = "Corsair";
                label3.Visible = true;
                pictureBox27.Visible = true;
            }
            if (comboBox1.Text == "Defense" && comboBox2.Text == "Rogue")
            {
                label3.Text = "Corsair";
                label3.Visible = true;
                pictureBox27.Visible = true;
            }
            if (comboBox1.Text == "Hunting" && comboBox2.Text == "Defense")
            {
                label3.Text = "Warden";
                label3.Visible = true;
                pictureBox28.Visible = true;
            }
            if (comboBox1.Text == "Defense" && comboBox2.Text == "Hunting")
            {
                label3.Text = "Warden";
                label3.Visible = true;
                pictureBox28.Visible = true;
            }
            if (comboBox1.Text == "Storm" && comboBox2.Text == "Defense")
            {
                label3.Text = "Paladin";
                label3.Visible = true;
                pictureBox29.Visible = true;
            }
            if (comboBox1.Text == "Defense" && comboBox2.Text == "Storm")
            {
                label3.Text = "Paladin";
                label3.Visible = true;
                pictureBox29.Visible = true;
            }
            if (comboBox1.Text == "Earth" && comboBox2.Text == "Defense")
            {
                label3.Text = "Juggernaut";
                label3.Visible = true;
                pictureBox30.Visible = true;
            }
            if (comboBox1.Text == "Defense" && comboBox2.Text == "Earth")
            {
                label3.Text = "Juggernaut";
                label3.Visible = true;
                pictureBox30.Visible = true;
            }
            if (comboBox1.Text == "Defense" && comboBox2.Text == "Defense")
            {
                label3.Text = "Defender";
                label3.Visible = true;
                pictureBox31.Visible = true;
            }
            if (comboBox1.Text == "Spirit" && comboBox2.Text == "Warfare")
            {
                label3.Text = "Spellbreaker";
                label3.Visible = true;
                pictureBox32.Visible = true;
            }
            if (comboBox1.Text == "Warfare" && comboBox2.Text == "Spirit")
            {
                label3.Text = "Spellbreaker";
                label3.Visible = true;
                pictureBox32.Visible = true;
            }
            if (comboBox1.Text == "Nature" && comboBox2.Text == "Warfare")
            {
                label3.Text = "Champion";
                label3.Visible = true;
                pictureBox33.Visible = true;
            }
            if (comboBox1.Text == "Warfare" && comboBox2.Text == "Nature")
            {
                label3.Text = "Champion";
                label3.Visible = true;
                pictureBox33.Visible = true;
            }
            if (comboBox1.Text == "Rogue" && comboBox2.Text == "Warfare")
            {
                label3.Text = "Assassin";
                label3.Visible = true;
                pictureBox34.Visible = true;
            }
            if (comboBox1.Text == "Warfare" && comboBox2.Text == "Rogue")
            {
                label3.Text = "Assassin";
                label3.Visible = true;
                pictureBox34.Visible = true;
            }
            if (comboBox1.Text == "Hunting" && comboBox2.Text == "Warfare")
            {
                label3.Text = "Slayer";
                label3.Visible = true;
                pictureBox35.Visible = true;
            }
            if (comboBox1.Text == "Warfare" && comboBox2.Text == "Hunting")
            {
                label3.Text = "Slayer";
                label3.Visible = true;
                pictureBox35.Visible = true;
            }
            if (comboBox1.Text == "Storm" && comboBox2.Text == "Warfare")
            {
                label3.Text = "Thane";
                label3.Visible = true;
                pictureBox36.Visible = true;
            }
            if (comboBox1.Text == "Warfare" && comboBox2.Text == "Storm")
            {
                label3.Text = "Thane";
                label3.Visible = true;
                pictureBox36.Visible = true;
            }
            if (comboBox1.Text == "Earth" && comboBox2.Text == "Warfare")
            {
                label3.Text = "Battlemage";
                label3.Visible = true;
                pictureBox37.Visible = true;
            }
            if (comboBox1.Text == "Warfare" && comboBox2.Text == "Earth")
            {
                label3.Text = "Battlemage";
                label3.Visible = true;
                pictureBox37.Visible = true;
            }
            if (comboBox1.Text == "Defense" && comboBox2.Text == "Warfare")
            {
                label3.Text = "Conqueror";
                label3.Visible = true;
                pictureBox38.Visible = true;
            }
            if (comboBox1.Text == "Warfare" && comboBox2.Text == "Defense")
            {
                label3.Text = "Conqueror";
                label3.Visible = true;
                pictureBox38.Visible = true;
            }
            if (comboBox1.Text == "Warfare" && comboBox2.Text == "Warfare")
            {
                label3.Text = "Warrior";
                label3.Visible = true;
                pictureBox39.Visible = true;
            }
            if (comboBox1.Text == "Spirit" && comboBox2.Text == "Dream")
            {
                label3.Text = "Diviner";
                label3.Visible = true;
                pictureBox40.Visible = true;
            }
            if (comboBox1.Text == "Dream" && comboBox2.Text == "Spirit")
            {
                label3.Text = "Diviner";
                label3.Visible = true;
                pictureBox40.Visible = true;
            }
            if (comboBox1.Text == "Nature" && comboBox2.Text == "Dream")
            {
                label3.Text = "Ritualist";
                label3.Visible = true;
                pictureBox41.Visible = true;
            }
            if (comboBox1.Text == "Dream" && comboBox2.Text == "Nature")
            {
                label3.Text = "Ritualist";
                label3.Visible = true;
                pictureBox41.Visible = true;
            }
            if (comboBox1.Text == "Rogue" && comboBox2.Text == "Dream")
            {
                label3.Text = "Dreamkiller";
                label3.Visible = true;
                pictureBox42.Visible = true;
            }
            if (comboBox1.Text == "Dream" && comboBox2.Text == "Rogue")
            {
                label3.Text = "Dreamkiller";
                label3.Visible = true;
                pictureBox42.Visible = true;
            }
            if (comboBox1.Text == "Hunting" && comboBox2.Text == "Dream")
            {
                label3.Text = "Haruspex";
                label3.Visible = true;
                pictureBox43.Visible = true;
            }
            if (comboBox1.Text == "Dream" && comboBox2.Text == "Hunting")
            {
                label3.Text = "Haruspex";
                label3.Visible = true;
                pictureBox43.Visible = true;
            }
            if (comboBox1.Text == "Storm" && comboBox2.Text == "Dream")
            {
                label3.Text = "Prophet";
                label3.Visible = true;
                pictureBox44.Visible = true;
            }
            if (comboBox1.Text == "Dream" && comboBox2.Text == "Storm")
            {
                label3.Text = "Prophet";
                label3.Visible = true;
                pictureBox44.Visible = true;
            }
            if (comboBox1.Text == "Earth" && comboBox2.Text == "Dream")
            {
                label3.Text = "Evoker";
                label3.Visible = true;
                pictureBox45.Visible = true;
            }
            if (comboBox1.Text == "Dream" && comboBox2.Text == "Earth")
            {
                label3.Text = "Evoker";
                label3.Visible = true;
                pictureBox45.Visible = true;
            }
            if (comboBox1.Text == "Defense" && comboBox2.Text == "Dream")
            {
                label3.Text = "Templar";
                label3.Visible = true;
                pictureBox46.Visible = true;
            }
            if (comboBox1.Text == "Dream" && comboBox2.Text == "Defense")
            {
                label3.Text = "Templar";
                label3.Visible = true;
                pictureBox46.Visible = true;
            }
            if (comboBox1.Text == "Warfare" && comboBox2.Text == "Dream")
            {
                label3.Text = "Harbinger";
                label3.Visible = true;
                pictureBox47.Visible = true;
            }
            if (comboBox1.Text == "Dream" && comboBox2.Text == "Warfare")
            {
                label3.Text = "Harbinger";
                label3.Visible = true;
                pictureBox47.Visible = true;
            }
            if (comboBox1.Text == "Dream" && comboBox2.Text == "Dream")
            {
                label3.Text = "Seer";
                label3.Visible = true;
                pictureBox48.Visible = true;
            }
            if (comboBox1.Text == "Spirit" && comboBox2.Text == "Rune")
            {
                label3.Text = "Shaman";
                label3.Visible = true;
                pictureBox49.Visible = true;
            }
            if (comboBox1.Text == "Rune" && comboBox2.Text == "Spirit")
            {
                label3.Text = "Shaman";
                label3.Visible = true;
                pictureBox49.Visible = true;
            }
            if (comboBox1.Text == "Nature" && comboBox2.Text == "Rune")
            {
                label3.Text = "Skinchanger";
                label3.Visible = true;
                pictureBox50.Visible = true;
            }
            if (comboBox1.Text == "Rune" && comboBox2.Text == "Nature")
            {
                label3.Text = "Skinchanger";
                label3.Visible = true;
                pictureBox50.Visible = true;
            }
            if (comboBox1.Text == "Rogue" && comboBox2.Text == "Rune")
            {
                label3.Text = "Trickster";
                label3.Visible = true;
                pictureBox51.Visible = true;
            }
            if (comboBox1.Text == "Rune" && comboBox2.Text == "Rogue")
            {
                label3.Text = "Trickster";
                label3.Visible = true;
                pictureBox51.Visible = true;
            }
            if (comboBox1.Text == "Hunting" && comboBox2.Text == "Rune")
            {
                label3.Text = "Dragon Hunter";
                label3.Visible = true;
                pictureBox52.Visible = true;
            }
            if (comboBox1.Text == "Rune" && comboBox2.Text == "Hunting")
            {
                label3.Text = "Dragon Hunter";
                label3.Visible = true;
                pictureBox52.Visible = true;
            }
            if (comboBox1.Text == "Storm" && comboBox2.Text == "Rune")
            {
                label3.Text = "Thunderer";
                label3.Visible = true;
                pictureBox53.Visible = true;
            }
            if (comboBox1.Text == "Rune" && comboBox2.Text == "Storm")
            {
                label3.Text = "Thunderer";
                label3.Visible = true;
                pictureBox53.Visible = true;
            }
            if (comboBox1.Text == "Earth" && comboBox2.Text == "Rune")
            {
                label3.Text = "Stonespeaker";
                label3.Visible = true;
                pictureBox54.Visible = true;
            }
            if (comboBox1.Text == "Rune" && comboBox2.Text == "Earth")
            {
                label3.Text = "Stonespeaker";
                label3.Visible = true;
                pictureBox54.Visible = true;
            }
            if (comboBox1.Text == "Defense" && comboBox2.Text == "Rune")
            {
                label3.Text = "Runesmith";
                label3.Visible = true;
                pictureBox55.Visible = true;
            }
            if (comboBox1.Text == "Rune" && comboBox2.Text == "Defense")
            {
                label3.Text = "Runesmith";
                label3.Visible = true;
                pictureBox55.Visible = true;
            }
            if (comboBox1.Text == "Warfare" && comboBox2.Text == "Rune")
            {
                label3.Text = "Berserker";
                label3.Visible = true;
                pictureBox56.Visible = true;
            }
            if (comboBox1.Text == "Rune" && comboBox2.Text == "Warfare")
            {
                label3.Text = "Berserker";
                label3.Visible = true;
                pictureBox56.Visible = true;
            }
            if (comboBox1.Text == "Dream" && comboBox2.Text == "Rune")
            {
                label3.Text = "Seidr Worker";
                label3.Visible = true;
                pictureBox57.Visible = true;
            }
            if (comboBox1.Text == "Rune" && comboBox2.Text == "Dream")
            {
                label3.Text = "Seidr Worker";
                label3.Visible = true;
                pictureBox57.Visible = true;
            }
            if (comboBox1.Text == "Rune" && comboBox2.Text == "Rune")
            {
                label3.Text = "Runemaster";
                label3.Visible = true;
                pictureBox58.Visible = true;
            }
            if (comboBox1.Text == "Spirit" && comboBox2.Text == "Neidan")
            {
                label3.Text = "Spiritualist";
                label3.Visible = true;
                pictureBox59.Visible = true;
            }
            if (comboBox1.Text == "Neidan" && comboBox2.Text == "Spirit")
            {
                label3.Text = "Spiritualist";
                label3.Visible = true;
                pictureBox59.Visible = true;
            }
            if (comboBox1.Text == "Nature" && comboBox2.Text == "Neidan")
            {
                label3.Text = "Hermit";
                label3.Visible = true;
                pictureBox60.Visible = true;
            }
            if (comboBox1.Text == "Neidan" && comboBox2.Text == "Nature")
            {
                label3.Text = "Hermit";
                label3.Visible = true;
                pictureBox60.Visible = true;
            }
            if (comboBox1.Text == "Rogue" && comboBox2.Text == "Neidan")
            {
                label3.Text = "Disruptor";
                label3.Visible = true;
                pictureBox61.Visible = true;
            }
            if (comboBox1.Text == "Neidan" && comboBox2.Text == "Rogue")
            {
                label3.Text = "Disruptor";
                label3.Visible = true;
                pictureBox61.Visible = true;
            }
            if (comboBox1.Text == "Hunting" && comboBox2.Text == "Neidan")
            {
                label3.Text = "Pilgrim";
                label3.Visible = true;
                pictureBox62.Visible = true;
            }
            if (comboBox1.Text == "Neidan" && comboBox2.Text == "Hunting")
            {
                label3.Text = "Pilgrim";
                label3.Visible = true;
                pictureBox62.Visible = true;
            }
            if (comboBox1.Text == "Storm" && comboBox2.Text == "Neidan")
            {
                label3.Text = "Channeler";
                label3.Visible = true;
                pictureBox63.Visible = true;
            }
            if (comboBox1.Text == "Neidan" && comboBox2.Text == "Storm")
            {
                label3.Text = "Channeler";
                label3.Visible = true;
                pictureBox63.Visible = true;
            }
            if (comboBox1.Text == "Earth" && comboBox2.Text == "Neidan")
            {
                label3.Text = "Wu";
                label3.Visible = true;
                pictureBox64.Visible = true;
            }
            if (comboBox1.Text == "Neidan" && comboBox2.Text == "Earth")
            {
                label3.Text = "Wu";
                label3.Visible = true;
                pictureBox64.Visible = true;
            }
            if (comboBox1.Text == "Defense" && comboBox2.Text == "Neidan")
            {
                label3.Text = "Monk";
                label3.Visible = true;
                pictureBox65.Visible = true;
            }
            if (comboBox1.Text == "Neidan" && comboBox2.Text == "Defense")
            {
                label3.Text = "Monk";
                label3.Visible = true;
                pictureBox65.Visible = true;
            }
            if (comboBox1.Text == "Warfare" && comboBox2.Text == "Neidan")
            {
                label3.Text = "Daoist";
                label3.Visible = true;
                pictureBox66.Visible = true;
            }
            if (comboBox1.Text == "Neidan" && comboBox2.Text == "Warfare")
            {
                label3.Text = "Daoist";
                label3.Visible = true;
                pictureBox66.Visible = true;
            }
            if (comboBox1.Text == "Dream" && comboBox2.Text == "Neidan")
            {
                label3.Text = "Contemplator";
                label3.Visible = true;
                pictureBox67.Visible = true;
            }
            if (comboBox1.Text == "Neidan" && comboBox2.Text == "Dream")
            {
                label3.Text = "Contemplator";
                label3.Visible = true;
                pictureBox67.Visible = true;
            }
            if (comboBox1.Text == "Rune" && comboBox2.Text == "Neidan")
            {
                label3.Text = "Esoterist";
                label3.Visible = true;
                pictureBox68.Visible = true;
            }
            if (comboBox1.Text == "Neidan" && comboBox2.Text == "Rune")
            {
                label3.Text = "Esoterist";
                label3.Visible = true;
                pictureBox68.Visible = true;
            }
            if (comboBox1.Text == "Neidan" && comboBox2.Text == "Neidan")
            {
                label3.Text = "Neidan";
                label3.Visible = true;
                pictureBox69.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            comboBox1.Text = null;
            comboBox2.Text = null;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
            pictureBox51.Visible = false;
            pictureBox52.Visible = false;
            pictureBox53.Visible = false;
            pictureBox54.Visible = false;
            pictureBox55.Visible = false;
            pictureBox56.Visible = false;
            pictureBox57.Visible = false;
            pictureBox58.Visible = false;
            pictureBox59.Visible = false;
            pictureBox60.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox67.Visible = false;
            pictureBox68.Visible = false;
            pictureBox69.Visible = false;
        }
    }
}