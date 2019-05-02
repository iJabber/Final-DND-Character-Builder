using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region global variables
        int race, type, speed;
        string strn, dex, con, intel, wis, cha;
        int strMod, dexMod, conMod, intMod, wisMod, chaMod, health;
        string level;
        System.Media.SoundPlayer buttonClick = new System.Media.SoundPlayer(@"C:\Users\DSU\Music\sfx_coin_single2.wav");
        System.Media.SoundPlayer dragonSound = new System.Media.SoundPlayer(@"C:\Users\DSU\Music\sfx_exp_long4.wav");
        System.Media.SoundPlayer gameMusic = new System.Media.SoundPlayer(@"C:\Users\DSU\Music\Legend of Zelda (NES) Intro.wav");

        

        public Form1()
        {
            InitializeComponent();
            DropGif();
            StartFlash();
            #region mouse hovers GUI01
            GUI01DragonbornButton.MouseEnter += OnMouseEnterDragonborn;
            GUI01DragonbornButton.MouseLeave += OnMouseLeaveDragonborn;
            GUI01DwarfButton.MouseEnter += OnMouseEnterDwarf;
            GUI01DwarfButton.MouseLeave += OnMouseLeaveDwarf;
            GUI01ElfButton.MouseEnter += OnMouseEnterElf;
            GUI01ElfButton.MouseLeave += OnMouseLeaveElf;
            GUI01HalfElfButton.MouseEnter += OnMouseEnterHalfElf;
            GUI01HalfElfButton.MouseLeave += OnMouseLeaveHalfElf;
            GUI01HalfOrcButton.MouseEnter += OnMouseEnterHalfOrc;
            GUI01HalfOrcButton.MouseLeave += OnMouseLeaveHalfOrc;
            GUI01HalflingButton.MouseEnter += OnMouseEnterHalfling;
            GUI01HalflingButton.MouseLeave += OnMouseLeaveHalfling;
            GUI01HumanButton.MouseEnter += OnMouseEnterHuman;
            GUI01HumanButton.MouseLeave += OnMouseLeaveHuman;
            GUI01GnomeButton.MouseEnter += OnMouseEnterGnome;
            GUI01GnomeButton.MouseLeave += OnMouseLeaveGnome;
            GUI01TieflingButton.MouseEnter += OnMouseEnterTiefling;
            GUI01TieflingButton.MouseLeave += OnMouseLeaveTiefling;
            GUI01AarakocraButton.MouseEnter += OnMouseEnterAarakocra;
            GUI01AarakocraButton.MouseLeave += OnMouseLeaveAarakocra;
            #endregion
            #region mouse hovers GUI02
            GUI02BarbarianButton.MouseEnter += OnMouseEnterBarbarian;
            GUI02BarbarianButton.MouseLeave += OnMouseLeaveBarbarian;
            GUI02BardButton.MouseEnter += OnMouseEnterBard;
            GUI02BardButton.MouseLeave += OnMouseLeaveBard;
            GUI02ClericButton.MouseEnter += OnMouseEnterCleric;
            GUI02ClericButton.MouseLeave += OnMouseLeaveCleric;
            GUI02DruidButton.MouseEnter += OnMouseEnterDruid;
            GUI02DruidButton.MouseLeave += OnMouseLeaveDruid;
            GUI02FighterButton.MouseEnter += OnMouseEnterFighter;
            GUI02FighterButton.MouseLeave += OnMouseLeaveFighter;
            GUI02MonkButton.MouseEnter += OnMouseEnterMonk;
            GUI02MonkButton.MouseLeave += OnMouseLeaveMonk;
            GUI02PaladinButton.MouseEnter += OnMouseEnterPaladin;
            GUI02PaladinButton.MouseLeave += OnMouseLeavePaladin;
            GUI02RangerButton.MouseEnter += OnMouseEnterRanger;
            GUI02RangerButton.MouseLeave += OnMouseLeaveRanger;
            GUI02RogueButton.MouseEnter += OnMouseEnterRogue;
            GUI02RogueButton.MouseLeave += OnMouseLeaveRogue;
            GUI02SorcererButton.MouseEnter += OnMouseEnterSorcerer;
            GUI02SorcererButton.MouseLeave += OnMouseLeaveSorcerer;
            GUI02WarlockButton.MouseEnter += OnMouseEnterWarlock;
            GUI02WarlockButton.MouseLeave += OnMouseLeaveWarlock;
            GUI02WizardButton.MouseEnter += OnMouseEnterWizard;
            GUI02WizardButton.MouseLeave += OnMouseLeaveWizard;
            #endregion
        }
        #endregion
        #region start up
        async Task DropGif()
        {
            dragonSound.Play();
            await Task.Delay(4100); // wait for 4.1 seconds
            this.DnDGif.Dispose();
        }
        async Task StartFlash()
        {
            await Task.Delay(4100); // wait for 4 second
            this.StartUpDrop.Visible = true;
            this.StartTitle.Visible = true;

            while (StartUpDrop.Visible == true)
            {
                await Task.Delay(1000); // wait for 4 second
                this.StartUpDrop.ForeColor = System.Drawing.Color.Black;
                await Task.Delay(200);
                this.StartUpDrop.ForeColor = System.Drawing.Color.White;
            }
        }

        private void StartUpDrop_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            this.StartUpDrop.Dispose();
            this.StartTitle.Dispose();
            GUI01();
        }
        #endregion
        #region GUI01

        public void GUI01()
        {

            gameMusic.Play();

            this.GUI01_Title.Visible = true;
            this.GUI01DragonbornButton.Visible = true;
            this.GUI01DwarfButton.Visible = true;
            this.GUI01ElfButton.Visible = true;
            this.GUI01HalfElfButton.Visible = true;
            this.GUI01HalfOrcButton.Visible = true;
            this.GUI01HalflingButton.Visible = true;
            this.GUI01HumanButton.Visible = true;
            this.GUI01GnomeButton.Visible = true;
            this.GUI01TieflingButton.Visible = true;
            this.GUI01AarakocraButton.Visible = true;
        }

        private void OnMouseEnterDragonborn(object sender, EventArgs e)
        {
            DragonBornTraitsLabel.Visible = true;
            this.GUI01HumanButton.Visible = false;
            this.GUI01TieflingButton.Visible = false;
            this.GUI01HalfElfButton.Visible = false;
            this.GUI01HalfOrcButton.Visible = false;
            this.GUI01HalflingButton.Visible = false;
        }
        private void OnMouseLeaveDragonborn(object sender, EventArgs e)
        {
            DragonBornTraitsLabel.Visible = false;
            this.GUI01HumanButton.Visible = true;
            this.GUI01TieflingButton.Visible = true;
            this.GUI01HalfElfButton.Visible = true;
            this.GUI01HalfOrcButton.Visible = true;
            this.GUI01HalflingButton.Visible = true;
        }
        private void OnMouseEnterDwarf(object sender, EventArgs e)
        {
            DwarfTraitsLabel.Visible = true;
            this.GUI01HumanButton.Visible = false;
            this.GUI01TieflingButton.Visible = false;
            this.GUI01GnomeButton.Visible = false;
            this.GUI01HalfElfButton.Visible = false;
            this.GUI01HalfOrcButton.Visible = false;
            this.GUI01HalflingButton.Visible = false;
        }
        private void OnMouseLeaveDwarf(object sender, EventArgs e)
        {
            DwarfTraitsLabel.Visible = false;
            this.GUI01HumanButton.Visible = true;
            this.GUI01TieflingButton.Visible = true;
            this.GUI01GnomeButton.Visible = true;
            this.GUI01HalfElfButton.Visible = true;
            this.GUI01HalfOrcButton.Visible = true;
            this.GUI01HalflingButton.Visible = true;
        }
        private void OnMouseEnterElf(object sender, EventArgs e)
        {
            ElfTraitsLabel.Visible = true;
            this.GUI01HalfElfButton.Visible = false;
            this.GUI01HalfOrcButton.Visible = false;
            this.GUI01GnomeButton.Visible = false;
            this.GUI01TieflingButton.Visible = false;
            this.GUI01HumanButton.Visible = false;
            this.GUI01HalflingButton.Visible = false;

        }
        private void OnMouseLeaveElf(object sender, EventArgs e)
        {
            ElfTraitsLabel.Visible = false;
            this.GUI01HalfElfButton.Visible = true;
            this.GUI01HalfOrcButton.Visible = true;
            this.GUI01GnomeButton.Visible = true;
            this.GUI01TieflingButton.Visible = true;
            this.GUI01HumanButton.Visible = true;
            this.GUI01HalflingButton.Visible = true;

        }
        private void OnMouseEnterHalfElf(object sender, EventArgs e)
        {
            HalfElfTraitsLabel.Visible = true;
            this.GUI01HumanButton.Visible = false;
            this.GUI01TieflingButton.Visible = false;
        }
        private void OnMouseLeaveHalfElf(object sender, EventArgs e)
        {
            HalfElfTraitsLabel.Visible = false;
            this.GUI01HumanButton.Visible = true;
            this.GUI01TieflingButton.Visible = true;
        }
        private void OnMouseEnterHalfOrc(object sender, EventArgs e)
        {
            HalfOrcTraitsLabel.Visible = true;
            this.GUI01HumanButton.Visible = false;
            this.GUI01TieflingButton.Visible = false;
        }
        private void OnMouseLeaveHalfOrc(object sender, EventArgs e)
        {
            HalfOrcTraitsLabel.Visible = false;
            this.GUI01HumanButton.Visible = true;
            this.GUI01TieflingButton.Visible = true;
        }
        private void OnMouseEnterHalfling(object sender, EventArgs e)
        {
            HalflingTraitsLabel.Visible = true;
            this.GUI01TieflingButton.Visible = false;
        }
        private void OnMouseLeaveHalfling(object sender, EventArgs e)
        {
            HalflingTraitsLabel.Visible = false;
            this.GUI01TieflingButton.Visible = true;
        }
        private void OnMouseEnterHuman(object sender, EventArgs e)
        {
            HumanTraitsLabel.Visible = true;
            this.GUI01DragonbornButton.Visible = false;
            this.GUI01DwarfButton.Visible = false;
            this.GUI01HalfElfButton.Visible = false;
            this.GUI01HalfOrcButton.Visible = false;
            this.GUI01ElfButton.Visible = false;
            this.GUI01HalflingButton.Visible = false;

        }
        private void OnMouseLeaveHuman(object sender, EventArgs e)
        {
            HumanTraitsLabel.Visible = false;
            this.GUI01DragonbornButton.Visible = true;
            this.GUI01DwarfButton.Visible = true;
            this.GUI01HalfElfButton.Visible = true;
            this.GUI01HalfOrcButton.Visible = true;
            this.GUI01ElfButton.Visible = true;
            this.GUI01HalflingButton.Visible = true;
        }
        private void OnMouseEnterGnome(object sender, EventArgs e)
        {
            GnomeTraitsLabel.Visible = true;
            this.GUI01HumanButton.Visible = false;
            this.GUI01TieflingButton.Visible = false;

        }
        private void OnMouseLeaveGnome(object sender, EventArgs e)
        {
            GnomeTraitsLabel.Visible = false;
            this.GUI01HumanButton.Visible = true;
            this.GUI01TieflingButton.Visible = true;
        }
        private void OnMouseEnterTiefling(object sender, EventArgs e)
        {
            TieflingTraitsLabel.Visible = true;
            this.GUI01DragonbornButton.Visible = false;
            this.GUI01DwarfButton.Visible = false;
            this.GUI01HalfElfButton.Visible = false;
            this.GUI01HalfOrcButton.Visible = false;
            this.GUI01AarakocraButton.Visible = false;
            this.GUI01GnomeButton.Visible = false;
            this.GUI01ElfButton.Visible = false;
            this.GUI01HalflingButton.Visible = false;
        }
        private void OnMouseLeaveTiefling(object sender, EventArgs e)
        {
            TieflingTraitsLabel.Visible = false;
            this.GUI01DragonbornButton.Visible = true;
            this.GUI01DwarfButton.Visible = true;
            this.GUI01HalfElfButton.Visible = true;
            this.GUI01HalfOrcButton.Visible = true;
            this.GUI01AarakocraButton.Visible = true;
            this.GUI01GnomeButton.Visible = true;
            this.GUI01ElfButton.Visible = true;
            this.GUI01HalflingButton.Visible = true;
        }
        private void OnMouseEnterAarakocra(object sender, EventArgs e)
        {
            AarakocraTraitsLabel.Visible = true;
            this.GUI01HalfElfButton.Visible = false;
            this.GUI01HalfOrcButton.Visible = false;
            this.GUI01GnomeButton.Visible = false;
            this.GUI01TieflingButton.Visible = false;
            this.GUI01HumanButton.Visible = false;
        }
        private void OnMouseLeaveAarakocra(object sender, EventArgs e)
        {
            AarakocraTraitsLabel.Visible = false;
            this.GUI01HalfElfButton.Visible = true;
            this.GUI01HalfOrcButton.Visible = true;
            this.GUI01GnomeButton.Visible = true;
            this.GUI01TieflingButton.Visible = true;
            this.GUI01HumanButton.Visible = true;
        }
        public void Dispose_of_GUI01()
        {
            this.GUI01_Title.Dispose();
            this.GUI01DragonbornButton.Dispose();
            this.GUI01DwarfButton.Dispose();
            this.GUI01ElfButton.Dispose();
            this.GUI01HalfElfButton.Dispose();
            this.GUI01HalfOrcButton.Dispose();
            this.GUI01HalflingButton.Dispose();
            this.GUI01HumanButton.Dispose();
            this.GUI01GnomeButton.Dispose();
            this.GUI01TieflingButton.Dispose();
            this.GUI01AarakocraButton.Dispose();

            DragonBornTraitsLabel.Dispose();
            DwarfTraitsLabel.Dispose();
            ElfTraitsLabel.Dispose();
            AarakocraTraitsLabel.Dispose();
            HalfOrcTraitsLabel.Dispose();
            HalfElfTraitsLabel.Dispose();
            HalflingTraitsLabel.Dispose();
            HumanTraitsLabel.Dispose();
            GnomeTraitsLabel.Dispose();
            TieflingTraitsLabel.Dispose();
        }
        private void GUI01AarakocraButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            race = 0;
            Dispose_of_GUI01();
            GUI02();
        }
        private void GUI01DragonbornButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            race = 1;
            Dispose_of_GUI01();
            GUI02();
        }

        private void GUI01DwarfButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            buttonClick.Stop();
            //gameMusic.LoadAsync();
            gameMusic.Play();
            race = 2;
            Dispose_of_GUI01();
            GUI02();
        }

        private void GUI01ElfButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            race = 3;
            Dispose_of_GUI01();
            GUI02();
        }

        private void GUI01GnomeButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            race = 4;
            Dispose_of_GUI01();
            GUI02();
        }

        private void GUI01HalfElfButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            race = 5;
            Dispose_of_GUI01();
            GUI02();
        }

        private void GUI01HalfOrcButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            race = 6;
            Dispose_of_GUI01();
            GUI02();
        }

        private void GUI01HalflingButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            race = 7;
            Dispose_of_GUI01();
            GUI02();
        }

        private void GUI01HumanButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            race = 8;
            Dispose_of_GUI01();
            GUI02();
        }
        private void GUI01TieflingButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            race = 9;
            Dispose_of_GUI01();
            GUI02();
        }
        #endregion
        #region GUI02
        public void GUI02()
        {
            GUI02_title.Visible = true;
            GUI02BarbarianButton.Visible = true;
            GUI02BardButton.Visible = true;
            GUI02ClericButton.Visible = true;
            GUI02DruidButton.Visible = true;
            GUI02FighterButton.Visible = true;
            GUI02MonkButton.Visible = true;
            GUI02PaladinButton.Visible = true;
            GUI02RangerButton.Visible = true;
            GUI02RogueButton.Visible = true;
            GUI02SorcererButton.Visible = true;
            GUI02WarlockButton.Visible = true;
            GUI02WizardButton.Visible = true;

        }
        #region GUI02 mouse hovers
        private void OnMouseEnterBarbarian(object sender, EventArgs e)
        {
            BarbarianLabel.Visible = true;
            this.GUI02MonkButton.Visible = false;
            this.GUI02PaladinButton.Visible = false;
            this.GUI02FighterButton.Visible = false;
        }
        private void OnMouseLeaveBarbarian(object sender, EventArgs e)
        {
            BarbarianLabel.Visible = false;
            this.GUI02MonkButton.Visible = true;
            this.GUI02PaladinButton.Visible = true;
            this.GUI02FighterButton.Visible = true;
        }
        private void OnMouseEnterBard(object sender, EventArgs e)
        {
            BardLabel.Visible = true;
            this.GUI02MonkButton.Visible = false;
            this.GUI02PaladinButton.Visible = false;
            this.GUI02RangerButton.Visible = false;
        }
        private void OnMouseLeaveBard(object sender, EventArgs e)
        {
            BardLabel.Visible = false;
            this.GUI02MonkButton.Visible = true;
            this.GUI02PaladinButton.Visible = true;
            this.GUI02RangerButton.Visible = true;
        }
        private void OnMouseEnterCleric(object sender, EventArgs e)
        {
            ClericLabel.Visible = true;
            this.GUI02MonkButton.Visible = false;
            this.GUI02PaladinButton.Visible = false;
            this.GUI02FighterButton.Visible = false;
        }
        private void OnMouseLeaveCleric(object sender, EventArgs e)
        {
            ClericLabel.Visible = false;
            this.GUI02MonkButton.Visible = true;
            this.GUI02PaladinButton.Visible = true;
            this.GUI02FighterButton.Visible = true;
        }
        private void OnMouseEnterDruid(object sender, EventArgs e)
        {
            DruidLabel.Visible = true;
            this.GUI02MonkButton.Visible = false;
            this.GUI02PaladinButton.Visible = false;
            this.GUI02RangerButton.Visible = false;
        }
        private void OnMouseLeaveDruid(object sender, EventArgs e)
        {
            DruidLabel.Visible = false;
            this.GUI02MonkButton.Visible = true;
            this.GUI02PaladinButton.Visible = true;
            this.GUI02RangerButton.Visible = true;
        }
        private void OnMouseEnterFighter(object sender, EventArgs e)
        {
            FighterLabel.Visible = true;
            this.GUI02WarlockButton.Visible = false;
            this.GUI02SorcererButton.Visible = false;
            this.GUI02RogueButton.Visible = false;
        }
        private void OnMouseLeaveFighter(object sender, EventArgs e)
        {
            FighterLabel.Visible = false;
            this.GUI02WarlockButton.Visible = true;
            this.GUI02SorcererButton.Visible = true;
            this.GUI02RogueButton.Visible = true;
        }
        private void OnMouseEnterMonk(object sender, EventArgs e)
        {
            MonkLabel.Visible = true;
            this.GUI02WizardButton.Visible = false;
            this.GUI02WarlockButton.Visible = false;
            this.GUI02SorcererButton.Visible = false;
        }
        private void OnMouseLeaveMonk(object sender, EventArgs e)
        {
            MonkLabel.Visible = false;
            this.GUI02WizardButton.Visible = true;
            this.GUI02WarlockButton.Visible = true;
            this.GUI02SorcererButton.Visible = true;
        }
        private void OnMouseEnterPaladin(object sender, EventArgs e)
        {
            PaladinLabel.Visible = true;
            this.GUI02WarlockButton.Visible = false;
            this.GUI02SorcererButton.Visible = false;
            this.GUI02RogueButton.Visible = false;

        }
        private void OnMouseLeavePaladin(object sender, EventArgs e)
        {
            PaladinLabel.Visible = false;
            this.GUI02WarlockButton.Visible = true;
            this.GUI02SorcererButton.Visible = true;
            this.GUI02RogueButton.Visible = true;
        }
        private void OnMouseEnterRanger(object sender, EventArgs e)
        {
            RangerLabel.Visible = true;
            this.GUI02WizardButton.Visible = false;
            this.GUI02WarlockButton.Visible = false;
            this.GUI02SorcererButton.Visible = false;
        }
        private void OnMouseLeaveRanger(object sender, EventArgs e)
        {
            RangerLabel.Visible = false;
            this.GUI02WizardButton.Visible = true;
            this.GUI02WarlockButton.Visible = true;
            this.GUI02SorcererButton.Visible = true;
        }
        private void OnMouseEnterRogue(object sender, EventArgs e)
        {
            RogueLabel.Visible = true;
            this.GUI02FighterButton.Visible = false;
            this.GUI02MonkButton.Visible = false;
            this.GUI02BarbarianButton.Visible = false;
            this.GUI02BardButton.Visible = false;
            this.GUI02PaladinButton.Visible = false;
            this.GUI02ClericButton.Visible = false;

        }
        private void OnMouseLeaveRogue(object sender, EventArgs e)
        {
            RogueLabel.Visible = false;
            this.GUI02FighterButton.Visible = true;
            this.GUI02MonkButton.Visible = true;
            this.GUI02BarbarianButton.Visible = true;
            this.GUI02BardButton.Visible = true;
            this.GUI02PaladinButton.Visible = true;
            this.GUI02ClericButton.Visible = true;
        }
        private void OnMouseEnterSorcerer(object sender, EventArgs e)
        {
            SorcererLabel.Visible = true;
            this.GUI02PaladinButton.Visible = false;
            this.GUI02MonkButton.Visible = false;
            this.GUI02RangerButton.Visible = false;
        }
        private void OnMouseLeaveSorcerer(object sender, EventArgs e)
        {
            SorcererLabel.Visible = false;
            this.GUI02PaladinButton.Visible = true;
            this.GUI02MonkButton.Visible = true;
            this.GUI02RangerButton.Visible = true;
        }
        private void OnMouseEnterWarlock(object sender, EventArgs e)
        {
            WarlockLabel.Visible = true;
            this.GUI02PaladinButton.Visible = false;
            this.GUI02MonkButton.Visible = false;
            this.GUI02RangerButton.Visible = false;
        }
        private void OnMouseLeaveWarlock(object sender, EventArgs e)
        {
            WarlockLabel.Visible = false;
            this.GUI02PaladinButton.Visible = true;
            this.GUI02MonkButton.Visible = true;
            this.GUI02RangerButton.Visible = true;
        }
        private void OnMouseEnterWizard(object sender, EventArgs e)
        {
            WizardLabel.Visible = true;
            this.GUI02ClericButton.Visible = false;
            this.GUI02DruidButton.Visible = false;
            this.GUI02PaladinButton.Visible = false;
            this.GUI02RangerButton.Visible = false;
        }
        private void OnMouseLeaveWizard(object sender, EventArgs e)
        {
            WizardLabel.Visible = false;
            this.GUI02ClericButton.Visible = true;
            this.GUI02DruidButton.Visible = true;
            this.GUI02PaladinButton.Visible = true;
            this.GUI02RangerButton.Visible = true;
        }

        #endregion

        public void DisposeGUI02()
        {
            GUI02_title.Dispose();
            GUI02BarbarianButton.Dispose();
            GUI02BardButton.Dispose();
            GUI02ClericButton.Dispose();
            GUI02DruidButton.Dispose();
            GUI02FighterButton.Dispose();
            GUI02MonkButton.Dispose();
            GUI02PaladinButton.Dispose();
            GUI02RangerButton.Dispose();
            GUI02RogueButton.Dispose();
            GUI02SorcererButton.Dispose();
            GUI02WarlockButton.Dispose();
            GUI02WizardButton.Dispose();
            WizardLabel.Dispose();
            WarlockLabel.Dispose();
            SorcererLabel.Dispose();
            RogueLabel.Dispose();
            RangerLabel.Dispose();
            PaladinLabel.Dispose();
            MonkLabel.Dispose();
            FighterLabel.Dispose();
            DruidLabel.Dispose();
            ClericLabel.Dispose();
            BardLabel.Dispose();
            BarbarianLabel.Dispose();
        }
        private void GUI02BarbarianButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            type = 1;
            DisposeGUI02();
            GUI03();
        }

        private void GUI02BardButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            type = 2;
            DisposeGUI02();
            GUI03();
        }

        private void GUI02ClericButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            type = 3;
            DisposeGUI02();
            GUI03();
        }

        private void GUI02DruidButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            type = 4;
            DisposeGUI02();
            GUI03();
        }

        private void GUI02FighterButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            type = 5;
            DisposeGUI02();
            GUI03();
        }

        private void GUI02MonkButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            type = 6;
            DisposeGUI02();
            GUI03();
        }

        private void GUI02PaladinButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            type = 7;
            DisposeGUI02();
            GUI03();
        }

        private void GUI02RangerButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            type = 8;
            DisposeGUI02();
            GUI03();
        }

        private void GUI02RogueButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            type = 9;
            DisposeGUI02();
            GUI03();
        }

        private void GUI02SorcererButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            type = 10;
            DisposeGUI02();
            GUI03();
        }

        private void GUI02WarlockButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            type = 11;
            DisposeGUI02();
            GUI03();
        }

        private void GUI02WizardButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            type = 12;
            DisposeGUI02();
            GUI03();
        }
        #endregion
        #region GUI03
        public void GUI03()
        {
            LevelHeader.Visible = true;
            LevelInput.Visible = true;
            LevelOkay.Visible = true;         
        }

        private void LevelOkay_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            LevelInput.Enabled = false;
            level = LevelInput.Text;
            if (level == "1" || level == "2" || level == "3")
            {
                StatsHeader.Visible = true;
                ORHeader.Visible = true;
                Rgns.Visible = true;
                USRINPT.Visible = true;
            }
        }

        private void Rgns_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            Rgns.Enabled = false;
            USRINPT.Enabled = false;
            RandomNumbers();
            StatBlocks();
        }

        private void USRINPT_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            Rgns.Enabled = false;
            USRINPT.Enabled = false;
            StatBlocks();
        }

         public void RandomNumbers()
        {
            Random rnd = new Random();
            int RandOne = rnd.Next(7, 17);
            int RandTwo = rnd.Next(7, 17);
            int RandThree = rnd.Next(7, 17);
            int RandFour = rnd.Next(7, 17);
            int RandFive = rnd.Next(7, 17);
            int RandSix = rnd.Next(7, 17);

            RandOneBox.Text = RandOne.ToString();
            RandTwoBox.Text = RandTwo.ToString();
            RandThreeBox.Text = RandThree.ToString();
            RandFourBox.Text = RandFour.ToString();
            RandFiveBox.Text = RandFive.ToString();
            RandSixBox.Text = RandSix.ToString();

            RandOneBox.Visible = true;
            RandTwoBox.Visible = true;
            RandThreeBox.Visible = true;
            RandFourBox.Visible = true;
            RandFiveBox.Visible = true;
            RandSixBox.Visible = true;

        }

        public void StatBlocks()
        {
            StrHeader.Visible = true;
            StrBlock.Visible = true;
            DexHeader.Visible = true;
            DexBlock.Visible = true;
            ConHeader.Visible = true;
            ConBlock.Visible = true;
            IntHeader.Visible = true;
            IntBlock.Visible = true;
            WisHeader.Visible = true;
            WisBlock.Visible = true;
            ChaHeader.Visible = true;
            ChaBlock.Visible = true;
            StatOkay.Visible = true;
        }

        private void StatOkay_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            strn = StrBlock.Text;
            dex = DexBlock.Text;
            con = ConBlock.Text;
            intel = IntBlock.Text;
            wis = WisBlock.Text;
            cha = ChaBlock.Text;
            if (strn == "1" || strn == "2" || strn == "3" || strn == "4" || strn == "5" || strn == "6" || strn == "7" || strn == "8" || strn == "9" || strn == "10" || strn == "11" || strn == "12" || strn == "13" || strn == "14" || strn == "15" || strn == "16" || strn == "17" || strn == "18" || strn == "19" || strn == "20")
                if (dex == "1" || dex == "2" || dex == "3" || dex == "4" || dex == "5" || dex == "6" || dex == "7" || dex == "8" || dex == "9" || dex == "10" || dex == "11" || dex == "12" || dex == "13" || dex == "14" || dex == "15" || dex == "16" || dex == "17" || dex == "18" || dex == "19" || dex == "20")
                    if (con == "1" || con == "2" || con == "3" || con == "4" || con == "5" || con == "6" || con == "7" || con == "8" || con == "9" || con == "10" || con == "11" || con == "12" || con == "13" || con == "14" || con == "15" || con == "16" || con == "17" || con == "18" || con == "19" || con == "20")
                        if (intel == "1" || intel == "2" || intel == "3" || intel == "4" || intel == "5" || intel == "6" || intel == "7" || intel == "8" || intel == "9" || intel == "10" || intel == "11" || intel == "12" || intel == "13" || intel == "14" || intel == "15" || intel == "16" || intel == "17" || intel == "18" || intel == "19" || intel == "20")
                            if (wis == "1" || wis == "2" || wis == "3" || wis == "4" || wis == "5" || wis == "6" || wis == "7" || wis == "8" || wis == "9" || wis == "10" || wis == "11" || wis == "12" || wis == "13" || wis == "14" || wis == "15" || wis == "16" || wis == "17" || wis == "18" || wis == "19" || wis == "20")
                                if (cha == "1" || cha == "2" || cha == "3" || cha == "4" || cha == "5" || cha == "6" || cha == "7" || cha == "8" || cha == "9" || cha == "10" || cha == "11" || cha == "12" || cha == "13" || cha == "14" || cha == "15" || cha == "16" || cha == "17" || cha == "18" || cha == "19" || cha == "20")
                                {
                                    CompleteLabel.Visible = true;
                                    NextButton.Visible = true;
                                }
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            buttonClick.Play();
            LevelHeader.Dispose();
            LevelInput.Dispose();
            LevelOkay.Dispose();
            StatsHeader.Dispose();
            StatOkay.Dispose();
            Rgns.Dispose();
            ORHeader.Dispose();
            USRINPT.Dispose();
            RandOneBox.Dispose();
            RandTwoBox.Dispose();
            RandThreeBox.Dispose();
            RandFourBox.Dispose();
            RandFiveBox.Dispose();
            RandSixBox.Dispose();

            StrHeader.Dispose();
            StrBlock.Dispose();
            DexHeader.Dispose();
            DexBlock.Dispose();
            ConHeader.Dispose();
            ConBlock.Dispose();
            IntHeader.Dispose();
            IntBlock.Dispose();
            WisHeader.Dispose();
            WisBlock.Dispose();
            ChaHeader.Dispose();
            ChaBlock.Dispose();
            CompleteLabel.Dispose();
            NextButton.Dispose();

            GUI04();
        }
        #endregion
        #region GUI04
        public void GUI04()
        {
            int FinalStr = Int32.Parse(strn);
            int FinalDex = Int32.Parse(dex);
            int FinalCon = Int32.Parse(con);
            int FinalInt = Int32.Parse(intel);
            int FinalWis = Int32.Parse(wis);
            int FinalCha = Int32.Parse(cha);

            if (race == 0)
            {
                raceHeader.Text = "Aarakocra";
                raceHeader.Visible = true;
                FinalDex = FinalDex + 2;
                FinalWis = FinalWis + 1;
                speed = 1;
                this.AarakocraTraitsLabel.ForeColor = System.Drawing.Color.White;
                DescOutput.Text = AarakocraTraitsLabel.Text;
                DescOutput.Visible = true;
            }
            else if (race == 1)
            {
                raceHeader.Text = "Dragonborn";
                raceHeader.Visible = true;
                FinalStr = FinalStr + 2;
                FinalCha = FinalCha + 1;
                speed = 2;
            }
            else if (race == 2)
            {
                raceHeader.Text = "Dwarf";
                raceHeader.Visible = true;
                FinalCon = FinalCon + 2;
                FinalStr = FinalStr + 2;
                speed = 1;
            }
            else if (race == 3)
            {
                raceHeader.Text = "Elf";
                raceHeader.Visible = true;
                FinalDex = FinalDex + 2;
                FinalInt = FinalInt + 1;
                speed = 2;
            }
            else if (race == 4)
            {
                raceHeader.Text = "Gnome";
                raceHeader.Visible = true;
                FinalInt = FinalInt + 2;
                speed = 1;
            }
            else if (race == 5)
            {
                raceHeader.Text = "Half  Elf";
                raceHeader.Visible = true;
                FinalCha = FinalCha + 2;
                FinalDex = FinalDex + 1;
                FinalCon = FinalCon + 1;
                speed = 2;
            }
            else if (race == 6)
            {
                raceHeader.Text = "Half  Orc";
                raceHeader.Visible = true;
                FinalStr = FinalStr + 2;
                FinalCon = FinalCon + 1;
                speed = 2;
            }
            else if (race == 7)
            {
                raceHeader.Text = "Halfling";
                raceHeader.Visible = true;
                FinalDex = FinalDex + 2;
                FinalCha = FinalCha + 1;
                speed = 1;
            }
            else if (race == 8)
            {
                raceHeader.Text = "Human";
                raceHeader.Visible = true;
                FinalDex = FinalDex + 1;
                FinalStr = FinalStr + 1;
                FinalCon = FinalCon + 1;
                FinalInt = FinalInt + 1;
                FinalWis = FinalWis + 1;
                FinalCha = FinalCha + 1;
                speed = 2;
            }
            else
            {
                raceHeader.Text = "Tiefling";
                raceHeader.Visible = true;
                FinalInt = FinalInt + 1;
                FinalCha = FinalCha + 2;
                speed = 2;
            }

            if (FinalStr == 1)
                strMod = -5;
            else if (FinalStr == 2 || FinalStr == 3)
                strMod = -4;
            else if (FinalStr == 4 || FinalStr == 5)
                strMod = -3;
            else if (FinalStr == 6 || FinalStr == 7)
                strMod = -2;
            else if (FinalStr == 8 || FinalStr == 9)
                strMod = -1;
            else if (FinalStr == 10 || FinalStr == 11)
                strMod = 0;
            else if (FinalStr == 12 || FinalStr == 13)
                strMod = 1;
            else if (FinalStr == 14 || FinalStr == 15)
                strMod = 2;
            else if (FinalStr == 16 || FinalStr == 17)
                strMod = 3;
            else if (FinalStr == 18 || FinalStr == 19)
                strMod = 4;
            else if (FinalStr == 20 || FinalStr == 21)
                strMod = 5;
            else
                strMod = 6;


            if (FinalDex == 1)
                dexMod = -5;
            else if (FinalDex == 2 || FinalDex == 3)
                dexMod = -4;
            else if (FinalDex == 4 || FinalDex == 5)
                dexMod = -3;
            else if (FinalDex == 6 || FinalDex == 7)
                dexMod = -2;
            else if (FinalDex == 8 || FinalDex == 9)
                dexMod = -1;
            else if (FinalDex == 10 || FinalDex == 11)
                dexMod = 0;
            else if (FinalDex == 12 || FinalDex == 13)
                dexMod = 1;
            else if (FinalDex == 14 || FinalDex == 15)
                dexMod = 2;
            else if (FinalDex == 16 || FinalDex == 17)
                dexMod = 3;
            else if (FinalDex == 18 || FinalDex == 19)
                dexMod = 4;
            else if (FinalDex == 20 || FinalDex == 21)
                dexMod = 5;
            else
                dexMod = 6;


            if (FinalCon == 1)
                conMod = -5;
            else if (FinalCon == 2 || FinalCon == 3)
                conMod = -4;
            else if (FinalCon == 4 || FinalCon == 5)
                conMod = -3;
            else if (FinalCon == 6 || FinalCon == 7)
                conMod = -2;
            else if (FinalCon == 8 || FinalCon == 9)
                conMod = -1;
            else if (FinalCon == 10 || FinalCon == 11)
                conMod = 0;
            else if (FinalCon == 12 || FinalCon == 13)
                conMod = 1;
            else if (FinalCon == 14 || FinalCon == 15)
                conMod = 2;
            else if (FinalCon == 16 || FinalCon == 17)
                conMod = 3;
            else if (FinalCon == 18 || FinalCon == 19)
                conMod = 4;
            else if (FinalCon == 20 || FinalCon == 21)
                conMod = 5;
            else
                conMod = 6;


            if (FinalInt == 1)
                intMod = -5;
            else if (FinalInt == 2 || FinalInt == 3)
                intMod = -4;
            else if (FinalInt == 4 || FinalInt == 5)
                intMod = -3;
            else if (FinalInt == 6 || FinalInt == 7)
                intMod = -2;
            else if (FinalInt == 8 || FinalInt == 9)
                intMod = -1;
            else if (FinalInt == 10 || FinalInt == 11)
                intMod = 0;
            else if (FinalInt == 12 || FinalInt == 13)
                intMod = 1;
            else if (FinalInt == 14 || FinalInt == 15)
                intMod = 2;
            else if (FinalInt == 16 || FinalInt == 17)
                intMod = 3;
            else if (FinalInt == 18 || FinalInt == 19)
                intMod = 4;
            else if (FinalInt == 20 || FinalInt == 21)
                intMod = 5;
            else
                intMod = 6;


            if (FinalWis == 1)
                wisMod = -5;
            else if (FinalWis == 2 || FinalWis == 3)
                wisMod = -4;
            else if (FinalWis == 4 || FinalWis == 5)
                wisMod = -3;
            else if (FinalWis == 6 || FinalWis == 7)
                wisMod = -2;
            else if (FinalWis == 8 || FinalWis == 9)
                wisMod = -1;
            else if (FinalWis == 10 || FinalWis == 11)
                wisMod = 0;
            else if (FinalWis == 12 || FinalWis == 13)
                wisMod = 1;
            else if (FinalWis == 14 || FinalWis == 15)
                wisMod = 2;
            else if (FinalWis == 16 || FinalWis == 17)
                wisMod = 3;
            else if (FinalWis == 18 || FinalWis == 19)
                wisMod = 4;
            else if (FinalWis == 20 || FinalWis == 21)
                wisMod = 5;
            else
                wisMod = 6;


            if (FinalCha == 1)
                chaMod = -5;
            else if (FinalCha == 2 || FinalCha == 3)
                chaMod = -4;
            else if (FinalCha == 4 || FinalCha == 5)
                chaMod = -3;
            else if (FinalCha == 6 || FinalCha == 7)
                chaMod = -2;
            else if (FinalCha == 8 || FinalCha == 9)
                chaMod = -1;
            else if (FinalCha == 10 || FinalCha == 11)
                chaMod = 0;
            else if (FinalCha == 12 || FinalCha == 13)
                chaMod = 1;
            else if (FinalCha == 14 || FinalCha == 15)
                chaMod = 2;
            else if (FinalCha == 16 || FinalCha == 17)
                chaMod = 3;
            else if (FinalCha == 18 || FinalCha == 19)
                chaMod = 4;
            else if (FinalCha == 20 || FinalCha == 21)
                chaMod = 5;
            else
                chaMod = 6;

            finalStrHeader.Visible = true;
            finalDexHeader.Visible = true;
            finalConHeader.Visible = true;
            finalIntHeader.Visible = true;
            finalWisHeader.Visible = true;
            finalChaHeader.Visible = true;

            strModBox.Text = strMod.ToString();
            dexModBox.Text = dexMod.ToString();
            conModBox.Text = conMod.ToString();
            intModBox.Text = intMod.ToString();
            wisModBox.Text = wisMod.ToString();
            chaModBox.Text = chaMod.ToString();

            strBox.Text = FinalStr.ToString();
            dexBox.Text = FinalDex.ToString();
            conBox.Text = FinalCon.ToString();
            intBox.Text = FinalInt.ToString();
            wisBox.Text = FinalWis.ToString();
            chaBox.Text = FinalCha.ToString();

            strModBox.Visible = true;
            dexModBox.Visible = true;
            conModBox.Visible = true;
            intModBox.Visible = true;
            wisModBox.Visible = true;
            chaModBox.Visible = true;

            strBox.Visible = true;
            dexBox.Visible = true;
            conBox.Visible = true;
            intBox.Visible = true;
            wisBox.Visible = true;
            chaBox.Visible = true;

            if (type == 1)
            {
                typeHeader.Text = "Barbarian";
                typeHeader.Visible = true;
                if (level == "1")
                {
                    health = 12 + conMod;
                    HitDieBox.Text = "1d12";
                }
                else if (level == "2")
                {
                    health = 12 + conMod + 7 + conMod;
                    HitDieBox.Text = "2d12";

                }
                else if (level == "3")
                {
                    health = 12 + conMod + 7 + conMod + 7 + conMod;
                    HitDieBox.Text = "3d12";
                }
                DescOutput.Text = BarbarianLabel.Text;
                DescOutput.Visible = true;
            }
            else if (type == 2)
            {
                typeHeader.Text = "Bard";
                typeHeader.Visible = true;
                if (level == "1")
                {
                    health = 8 + conMod;
                    HitDieBox.Text = "1d8";
                }
                else if (level == "2")
                {
                    health = 8 + conMod + 5 + conMod;
                    HitDieBox.Text = "2d8";
                }
                else if (level == "3")
                {
                    health = 8 + conMod + 5 + conMod + 5 + conMod;
                    HitDieBox.Text = "3d8";
                }
                DescOutput.Text = BardLabel.Text;
                DescOutput.Visible = true;
            }
            else if (type == 3)
            {
                typeHeader.Text = "Cleric";
                typeHeader.Visible = true;
                if (level == "1")
                {
                    health = 8 + conMod;
                    HitDieBox.Text = "1d8";
                }
                else if (level == "2")
                {
                    health = 8 + conMod + 5 + conMod;
                    HitDieBox.Text = "2d8";
                }
                else if (level == "3")
                {
                    health = 8 + conMod + 5 + conMod + 5 + conMod;
                    HitDieBox.Text = "3d8";
                }
                DescOutput.Text = ClericLabel.Text;
                DescOutput.Visible = true;
            }
            else if (type == 4)
            {
                typeHeader.Text = "Druid";
                typeHeader.Visible = true;
                if (level == "1")
                {
                    health = 8 + conMod;
                    HitDieBox.Text = "1d8";
                }
                else if (level == "2")
                {
                    health = 8 + conMod + 5 + conMod;
                    HitDieBox.Text = "2d8";
                }
                else if (level == "3")
                {
                    health = 8 + conMod + 5 + conMod + 5 + conMod;
                    HitDieBox.Text = "3d8";
                }
                DescOutput.Text = DruidLabel.Text;
                DescOutput.Visible = true;
            }
            else if (type == 5)
            {
                typeHeader.Text = "Fighter";
                typeHeader.Visible = true;
                if (level == "1")
                {
                    health = 10 + conMod;
                    HitDieBox.Text = "1d10";
                }
                else if (level == "2")
                {
                    health = 10 + conMod + 6 + conMod;
                    HitDieBox.Text = "2d10";
                }
                else if (level == "3")
                {
                    health = 10 + conMod + 6 + conMod + 6 + conMod;
                    HitDieBox.Text = "3d10";
                }
                DescOutput.Text = FighterLabel.Text;
                DescOutput.Visible = true;
            }
            else if (type == 6)
            {
                typeHeader.Text = "Monk";
                typeHeader.Visible = true;
                if (level == "1")
                {
                    health = 8 + conMod;
                    HitDieBox.Text = "1d8";
                }
                else if (level == "2")
                {
                    health = 8 + conMod + 5 + conMod;
                    HitDieBox.Text = "2d8";
                }
                else if (level == "3")
                {
                    health = 8 + conMod + 5 + conMod + 5 + conMod;
                    HitDieBox.Text = "3d8";
                }
                DescOutput.Text = MonkLabel.Text;
                DescOutput.Visible = true;
            }
            else if (type == 7)
            {
                typeHeader.Text = "Paladin";
                typeHeader.Visible = true;
                if (level == "1")
                {
                    health = 10 + conMod;
                    HitDieBox.Text = "1d10";
                }
                else if (level == "2")
                {
                    health = 10 + conMod + 6 + conMod;
                    HitDieBox.Text = "2d10";
                }
                else if (level == "3")
                {
                    health = 10 + conMod + 6 + conMod + 6 + conMod;
                    HitDieBox.Text = "3d10";
                }
                DescOutput.Text = PaladinLabel.Text;
                DescOutput.Visible = true;
            }
            else if (type == 8)
            {
                typeHeader.Text = "Ranger";
                typeHeader.Visible = true;
                if (level == "1")
                {
                    health = 10 + conMod;
                    HitDieBox.Text = "1d10";
                }
                else if (level == "2")
                {
                    health = 10 + conMod + 6 + conMod;
                    HitDieBox.Text = "2d10";
                }
                else if (level == "3")
                {
                    health = 10 + conMod + 6 + conMod + 6 + conMod;
                    HitDieBox.Text = "3d10";
                }
                DescOutput.Text = RangerLabel.Text;
                DescOutput.Visible = true;
            }
            else if (type == 9)
            {
                typeHeader.Text = "Rogue";
                typeHeader.Visible = true;
                if (level == "1")
                {
                    health = 8 + conMod;
                    HitDieBox.Text = "1d8";
                }
                else if (level == "2")
                {
                    health = 8 + conMod + 5 + conMod;
                    HitDieBox.Text = "2d8";
                }
                else if (level == "3")
                {
                    health = 8 + conMod + 5 + conMod + 5 + conMod;
                    HitDieBox.Text = "3d8";
                }
                DescOutput.Text = RogueLabel.Text;
                DescOutput.Visible = true;
            }
            else if (type == 10)
            {
                typeHeader.Text = "Sorcerer";
                typeHeader.Visible = true;
                if (level == "1")
                {
                    health = 6 + conMod;
                    HitDieBox.Text = "1d6";
                }
                else if (level == "2")
                {
                    health = 6 + conMod + 4 + conMod;
                    HitDieBox.Text = "2d6";
                }
                else if (level == "3")
                {
                    health = 6 + conMod + 4 + conMod + 4 + conMod;
                    HitDieBox.Text = "3d6";
                }
                DescOutput.Text = SorcererLabel.Text;
                DescOutput.Visible = true;
            }
            else if (type == 11)
            {
                typeHeader.Text = "Warlock";
                typeHeader.Visible = true;
                if (level == "1")
                {
                    health = 8 + conMod;
                    HitDieBox.Text = "1d8";
                }
                else if (level == "2")
                {
                    health = 8 + conMod + 5 + conMod;
                    HitDieBox.Text = "2d8";
                }
                else if (level == "3")
                {
                    health = 8 + conMod + 5 + conMod + 5 + conMod;
                    HitDieBox.Text = "3d8";
                }
                DescOutput.Text = WarlockLabel.Text;
                DescOutput.Visible = true;
            }
            else
            {
                typeHeader.Text = "Wizard";
                typeHeader.Visible = true;
                if (level == "1")
                {
                    health = 6 + conMod;
                    HitDieBox.Text = "1d6";
                }
                else if (level == "2")
                {
                    health = 6 + conMod + 4 + conMod;
                    HitDieBox.Text = "2d6";
                }
                else if (level == "3")
                {
                    health = 6 + conMod + 4 + conMod + 4 + conMod;
                    HitDieBox.Text = "3d6";
                }
                DescOutput.Text = WizardLabel.Text;
                DescOutput.Visible = true;
            }
            HealthBoxFinal.Text = health.ToString();
            if (speed == 1)
                speedBox.Text = "25";
            else
                speedBox.Text = "30";
            HealthBoxFinal.Visible = true;
            HealthHeaderFinal.Visible = true;
            HitDieBox.Visible = true;
            HitDieHeader.Visible = true;
            speedBox.Visible = true;
            speedHeader.Visible = true;

        }
        #endregion
    }
}