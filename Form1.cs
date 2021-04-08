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
            this.Controls.Add(new Item(new Image[] { Resources.Ocarina_of_Time }, 14, 6, null, true));
            Item bow = new Item(new Image[] { Resources.Hero_s_Bow, Resources.Hero_s_Bow_40, Resources.Hero_s_Bow_50 }, 56, 6);
            this.Controls.Add(bow);
            this.Controls.Add(new Item(new Image[] { Resources.Fire_Arrow }, 98, 6));
            this.Controls.Add(new Item(new Image[] { Resources.Ice_Arrow }, 140, 6));
            this.Controls.Add(new Item(new Image[] { Resources.Light_Arrow }, 182, 6));
            this.Controls.Add(new Item(new Image[] { Resources.Moon_s_Tear, Resources.Land_Title_Deed, Resources.Swamp_Title_Deed,
                Resources.Mountain_Title_Deed, Resources.Ocean_Title_Deed}, 224, 6));
            // Row 2
            Item bombs = new Item(new Image[] { Resources.Bomb, Resources.Bomb_30, Resources.Bomb_40 }, 14, 42);
            this.Controls.Add(bombs);
            this.Controls.Add(new Item(new Image[] { Resources.Bombchu }, 56, 42));
            this.Controls.Add(new Item(new Image[] { Resources.Deku_Stick }, 98, 42));
            this.Controls.Add(new Item(new Image[] { Resources.Deku_Nut }, 140, 42));
            this.Controls.Add(new Item(new Image[] { Resources.Magic_Beans }, 182, 42));
            this.Controls.Add(new Item(new Image[] { Resources.Room_Key, Resources.Special_Delivery_to_Mama }, 224, 42));

            // Row 3
            this.Controls.Add(new Item(new Image[] { Resources.Powder_Keg }, 14, 78));
            this.Controls.Add(new Item(new Image[] { Resources.Pictograph_Box }, 56, 78));
            this.Controls.Add(new Item(new Image[] { Resources.Lens_of_Truth }, 98, 78));
            this.Controls.Add(new Item(new Image[] { Resources.Hookshot }, 140, 78));
            this.Controls.Add(new Item(new Image[] { Resources.Great_Fairy_s_Sword }, 182, 78));
            this.Controls.Add(new Item(new Image[] { Resources.Letter_to_Kafei }, 224, 78));
            // Row 4
            this.Controls.Add(new Item(new Image[] { Resources.Red_Potion }, 14, 114));
            this.Controls.Add(new Item(new Image[] { Resources.Gold_Dust }, 56, 114));
            this.Controls.Add(new Item(new Image[] { Resources.Milk }, 98, 114));
            this.Controls.Add(new Item(new Image[] { Resources.Chateau_Romani }, 140, 114));
            this.Controls.Add(new Item(new Image[] { Resources.Empty_Bottle }, 182, 114));
            this.Controls.Add(new Item(new Image[] { Resources.Big_Poe }, 224, 114));

            // Mask Screen
            // Row 1
            this.Controls.Add(new Item(new Image[] { Resources.Postman_s_Hat }, 14, 153));
            this.Controls.Add(new Item(new Image[] { Resources.All_Night_Mask }, 56, 153));
            this.Controls.Add(new Item(new Image[] { Resources.Blast_Mask }, 98, 153));
            this.Controls.Add(new Item(new Image[] { Resources.Stone_Mask }, 140, 153));
            this.Controls.Add(new Item(new Image[] { Resources.Great_Fairy_s_Mask }, 182, 153));
            this.Controls.Add(new Item(new Image[] { Resources.Deku_Mask }, 224, 153));
            // Row 2
            this.Controls.Add(new Item(new Image[] { Resources.Keaton_Mask }, 14, 189));
            this.Controls.Add(new Item(new Image[] { Resources.Bremen_Mask }, 56, 189));
            this.Controls.Add(new Item(new Image[] { Resources.Bunny_Hood }, 98, 189));
            this.Controls.Add(new Item(new Image[] { Resources.Don_Gero_s_Mask }, 140, 189));
            this.Controls.Add(new Item(new Image[] { Resources.Mask_of_Scents }, 182, 189));
            this.Controls.Add(new Item(new Image[] { Resources.Goron_Mask }, 224, 189));
            // Row 3
            this.Controls.Add(new Item(new Image[] { Resources.Romani_s_Mask }, 14, 225));
            this.Controls.Add(new Item(new Image[] { Resources.Circus_Leader_s_Mask }, 56, 225));
            this.Controls.Add(new Item(new Image[] { Resources.Kafei_s_Mask }, 98, 225));
            this.Controls.Add(new Item(new Image[] { Resources.Couple_s_Mask }, 140, 225));
            this.Controls.Add(new Item(new Image[] { Resources.Mask_of_Truth }, 182, 225));
            this.Controls.Add(new Item(new Image[] { Resources.Zora_Mask }, 224, 225));
            // Row 4
            this.Controls.Add(new Item(new Image[] { Resources.Kamaro_s_Mask }, 14, 261));
            this.Controls.Add(new Item(new Image[] { Resources.Gibdo_Mask }, 56, 261));
            this.Controls.Add(new Item(new Image[] { Resources.Garo_s_Mask }, 98, 261));
            this.Controls.Add(new Item(new Image[] { Resources.Captain_s_Hat }, 140, 261));
            this.Controls.Add(new Item(new Image[] { Resources.Giant_s_Mask }, 182, 261));
            this.Controls.Add(new Item(new Image[] { Resources.Fierce_Deity_s_Mask }, 224, 261));

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

            const int SONGY = 307;
            const int SONGY2 = 336;

            this.Controls.Add(new Item(new Image[] { Resources.Song_of_Time }, 28, SONGY, checkMarks[0], true, true));
            this.Controls.Add(new Item(new Image[] { Resources.Song_of_Healing }, 70, SONGY, checkMarks[1], false, true));
            this.Controls.Add(new Item(new Image[] { Resources.Epona_s_Song }, 112, SONGY, checkMarks[2]));
            this.Controls.Add(new Item(new Image[] { Resources.Song_of_Soaring }, 154, SONGY, checkMarks[3], true, true));
            this.Controls.Add(new Item(new Image[] { Resources.Song_of_Storms }, 196, SONGY, checkMarks[4]));
            this.Controls.Add(new Item(new Image[] { Resources.Sonata_of_Awakening }, 28, SONGY2, checkMarks[5]));
            this.Controls.Add(new Item(new Image[] { Resources.Goron_Lullaby }, 70, SONGY2, checkMarks[6]));
            this.Controls.Add(new Item(new Image[] { Resources.New_Wave_Bossa_Nova }, 112, SONGY2, checkMarks[7]));
            this.Controls.Add(new Item(new Image[] { Resources.Elegy_of_Emptiness }, 154, SONGY2, checkMarks[8]));
            this.Controls.Add(new Item(new Image[] { Resources.Oath_to_Order }, 196, SONGY2, checkMarks[9]));

            // Quest Item Status Screen
            // Remains
            this.Controls.Add(new Item(new Image[] { Resources.Odolwa_s_Remains }, 57, 421));
            this.Controls.Add(new Item(new Image[] { Resources.Goht_s_Remains }, 56, 381));
            this.Controls.Add(new Item(new Image[] { Resources.Gyorg_s_Remains }, 15, 401));
            this.Controls.Add(new Item(new Image[] { Resources.Twinmold_s_Remains }, 98, 402));

            // Upgrades
            // Row 1
            this.Controls.Add(new Item(new Image[] { Resources.Kokiri_Sword, Resources.Razor_Sword, Resources.Gilded_Sword}, 139, 382, null, true));
            this.Controls.Add(new Item(new Image[] { Resources.Hero_s_Shield, Resources.Mirror_Shield }, 181, 382, null, true));
            this.Controls.Add(new Item(new Image[] { Resources.magic1, Resources.magic2 }, 223, 382));
            // Row 2
            Item quiver = new Item(new Image[] { Resources.Quiver_30, Resources.Quiver_40, Resources.Quiver_50 }, 139, 420);
            this.Controls.Add(quiver);
            Item bombBag = new Item(new Image[] { Resources.Bomb_Bag_20, Resources.Bomb_Bag_30, Resources.Bomb_Bag_40 }, 181, 420);
            this.Controls.Add(bombBag);
            this.Controls.Add(new Item(new Image[] { Resources.Adult_s_Wallet, Resources.Giant_s_Wallet }, 223, 420));

            bow.PairedItem = quiver;
            quiver.PairedItem = bow;

            bombs.PairedItem = bombBag;
            bombBag.PairedItem = bombs;
        }
    }
}
