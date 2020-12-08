using mm_item_tracker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mm_item_tracker
{
    public partial class MMR_Tracker : Form
    {
        public MMR_Tracker()
        {
            InitializeComponent();
            // Item Screen
            // Row 1            
            this.Controls.Add(new Item(new Image[] { Resources.Ocarina_of_Time }, 7, 12, null, true));
            Item bow = new Item(new Image[] { Resources.Hero_s_Bow, Resources.Hero_s_Bow_40, Resources.Hero_s_Bow_50 }, 49, 12);
            this.Controls.Add(bow);
            this.Controls.Add(new Item(new Image[] { Resources.Fire_Arrow }, 91, 12));
            this.Controls.Add(new Item(new Image[] { Resources.Ice_Arrow }, 133, 12));
            this.Controls.Add(new Item(new Image[] { Resources.Light_Arrow }, 175, 12));
            this.Controls.Add(new Item(new Image[] { Resources.Moon_s_Tear, Resources.Land_Title_Deed, Resources.Swamp_Title_Deed,
                Resources.Mountain_Title_Deed, Resources.Ocean_Title_Deed}, 217, 12));
            // Row 2
            Item bombs = new Item(new Image[] { Resources.Bomb, Resources.Bomb_30, Resources.Bomb_40 }, 7, 60);
            this.Controls.Add(bombs);
            this.Controls.Add(new Item(new Image[] { Resources.Bombchu }, 49, 60));
            this.Controls.Add(new Item(new Image[] { Resources.Deku_Stick }, 91, 60));
            this.Controls.Add(new Item(new Image[] { Resources.Deku_Nut }, 133, 60));
            this.Controls.Add(new Item(new Image[] { Resources.Magic_Beans }, 175, 60));
            this.Controls.Add(new Item(new Image[] { Resources.Room_Key, Resources.Special_Delivery_to_Mama }, 217, 60));

            // Row 3
            this.Controls.Add(new Item(new Image[] { Resources.Powder_Keg }, 7, 108));
            this.Controls.Add(new Item(new Image[] { Resources.Pictograph_Box }, 49, 108));
            this.Controls.Add(new Item(new Image[] { Resources.Lens_of_Truth }, 91, 108));
            this.Controls.Add(new Item(new Image[] { Resources.Hookshot }, 133, 108));
            this.Controls.Add(new Item(new Image[] { Resources.Great_Fairy_s_Sword }, 175, 108));
            this.Controls.Add(new Item(new Image[] { Resources.Letter_to_Kafei }, 217, 108));
            // Row 4
            this.Controls.Add(new Item(new Image[] { Resources.Red_Potion }, 7, 156));
            this.Controls.Add(new Item(new Image[] { Resources.Gold_Dust }, 49, 156));
            this.Controls.Add(new Item(new Image[] { Resources.Milk }, 91, 156));
            this.Controls.Add(new Item(new Image[] { Resources.Chateau_Romani }, 133, 156));
            this.Controls.Add(new Item(new Image[] { Resources.Empty_Bottle }, 175, 156));
            this.Controls.Add(new Item(new Image[] { Resources.Big_Poe }, 217, 156));

            // Mask Screen
            // Row 1
            this.Controls.Add(new Item(new Image[] { Resources.Postman_s_Hat }, 7, 211));
            this.Controls.Add(new Item(new Image[] { Resources.All_Night_Mask }, 49, 211));
            this.Controls.Add(new Item(new Image[] { Resources.Blast_Mask }, 91, 211));
            this.Controls.Add(new Item(new Image[] { Resources.Stone_Mask }, 133, 211));
            this.Controls.Add(new Item(new Image[] { Resources.Great_Fairy_s_Mask }, 175, 211));
            this.Controls.Add(new Item(new Image[] { Resources.Deku_Mask }, 217, 211));
            // Row 2
            this.Controls.Add(new Item(new Image[] { Resources.Keaton_Mask }, 7, 259));
            this.Controls.Add(new Item(new Image[] { Resources.Bremen_Mask }, 49, 259));
            this.Controls.Add(new Item(new Image[] { Resources.Bunny_Hood }, 91, 259));
            this.Controls.Add(new Item(new Image[] { Resources.Don_Gero_s_Mask }, 133, 259));
            this.Controls.Add(new Item(new Image[] { Resources.Mask_of_Scents }, 175, 259));
            this.Controls.Add(new Item(new Image[] { Resources.Goron_Mask }, 217, 259));
            // Row 3
            this.Controls.Add(new Item(new Image[] { Resources.Romani_s_Mask }, 7, 307));
            this.Controls.Add(new Item(new Image[] { Resources.Circus_Leader_s_Mask }, 49, 307));
            this.Controls.Add(new Item(new Image[] { Resources.Kafei_s_Mask }, 91, 307));
            this.Controls.Add(new Item(new Image[] { Resources.Couple_s_Mask }, 133, 307));
            this.Controls.Add(new Item(new Image[] { Resources.Mask_of_Truth }, 175, 307));
            this.Controls.Add(new Item(new Image[] { Resources.Zora_Mask }, 217, 307));
            // Row 4
            this.Controls.Add(new Item(new Image[] { Resources.Kamaro_s_Mask }, 7, 355));
            this.Controls.Add(new Item(new Image[] { Resources.Gibdo_Mask }, 49, 355));
            this.Controls.Add(new Item(new Image[] { Resources.Garo_s_Mask }, 91, 355));
            this.Controls.Add(new Item(new Image[] { Resources.Captain_s_Hat }, 133, 355));
            this.Controls.Add(new Item(new Image[] { Resources.Giant_s_Mask }, 175, 355));
            this.Controls.Add(new Item(new Image[] { Resources.Fierce_Deity_s_Mask }, 217, 355));

            // Quest Item Status Screen
            // Remains
            this.Controls.Add(new Item(new Image[] { Resources.Odolwa_s_Remains }, 51, 466));
            this.Controls.Add(new Item(new Image[] { Resources.Goht_s_Remains }, 49, 407));
            this.Controls.Add(new Item(new Image[] { Resources.Gyorg_s_Remains }, 8, 436));
            this.Controls.Add(new Item(new Image[] { Resources.Twinmold_s_Remains }, 91, 437));

            // Upgrades
            // Row 1
            this.Controls.Add(new Item(new Image[] { Resources.Kokiri_Sword, Resources.Razor_Sword, Resources.Gilded_Sword}, 132, 413, null, true));
            this.Controls.Add(new Item(new Image[] { Resources.Hero_s_Shield, Resources.Mirror_Shield }, 174, 413, null, true));
            this.Controls.Add(new Item(new Image[] { Resources.magic1, Resources.magic2 }, 216, 413));
            // Row 2
            Item quiver = new Item(new Image[] { Resources.Quiver_30, Resources.Quiver_40, Resources.Quiver_50 }, 132, 461);
            this.Controls.Add(quiver);
            Item bombBag = new Item(new Image[] { Resources.Bomb_Bag_20, Resources.Bomb_Bag_30, Resources.Bomb_Bag_40 }, 174, 461);
            this.Controls.Add(bombBag);
            this.Controls.Add(new Item(new Image[] { Resources.Adult_s_Wallet, Resources.Giant_s_Wallet }, 216, 461));

            // Songs
            PictureBox[] checkMarks = new PictureBox[10];
            for (int i = 0; i < checkMarks.Length; i++)
            {
                checkMarks[i] = new PictureBox();
                checkMarks[i].BackgroundImage = Resources.checkmark;
                checkMarks[i].Size = Resources.checkmark.Size;
                checkMarks[i].BackColor = Color.Transparent;
                checkMarks[i].Visible = false;
                this.Controls.Add(checkMarks[i]);
            }
                
            this.Controls.Add(new Item(new Image[] { Resources.Song_of_Time }, 256, 11, checkMarks[0], true, true));
            this.Controls.Add(new Item(new Image[] { Resources.Song_of_Healing }, 256, 61, checkMarks[1], false, true));
            this.Controls.Add(new Item(new Image[] { Resources.Epona_s_Song }, 256, 111, checkMarks[2]));
            this.Controls.Add(new Item(new Image[] { Resources.Song_of_Soaring }, 256, 161, checkMarks[3], true, true));
            this.Controls.Add(new Item(new Image[] { Resources.Song_of_Storms }, 256, 211, checkMarks[4]));
            this.Controls.Add(new Item(new Image[] { Resources.Sonata_of_Awakening }, 256, 261, checkMarks[5]));
            this.Controls.Add(new Item(new Image[] { Resources.Goron_Lullaby }, 256, 311, checkMarks[6]));
            this.Controls.Add(new Item(new Image[] { Resources.New_Wave_Bossa_Nova }, 256, 361, checkMarks[7]));
            this.Controls.Add(new Item(new Image[] { Resources.Elegy_of_Emptiness }, 256, 411, checkMarks[8]));
            this.Controls.Add(new Item(new Image[] { Resources.Oath_to_Order }, 256, 461, checkMarks[9]));

            bow.PairedItem = quiver;
            quiver.PairedItem = bow;

            bombs.PairedItem = bombBag;
            bombBag.PairedItem = bombs;
        }
    }
}
