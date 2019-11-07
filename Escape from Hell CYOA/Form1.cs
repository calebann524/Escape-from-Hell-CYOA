using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Escape_from_Hell_CYOA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int scene = 0;
            if (e.KeyCode == Keys.D)
            {
                switch (scene)
                {
                    case 1:
                        scene = 2;
                        break;
                }
            }

            switch (scene)
            {
                case 0: //starting scene
                    outputLabel.Text = "You are chained to a a red brick wall, smoke and sulfur is what you smell. do you try to pull free? or break the chains";
                    leftButton.Text = "Squeeze from between the bars";
                    rightButton.Text = "Break the chains with raw strength";
                    break;
                case 1:
                    outputLabel.Text = "you manage to squeeze your hand through the chains, chafing your wrists, but you are now free \nthere is a door, or a window, through the window you can see a fire strewn landscape, while the door leads to a rather fancy hallway.";
                    leftButton.Text = "escape through the window";
                    rightButton.Text = "go down the hallway";
                    break;

                case 2:
                    outputLabel.Text = "as you strain against the chains they clank loudly, attracting the attention of your jailor, a demon. . ." + " 'Looks like you're awake. . . what a shame, I thought you'd take longer. .' \n those were the last words you ever heard, as the demons club bashed into your head, knocking you out. . . you did not wake up again.";
                    leftButton.Text = "  ";
                    rightButton.Text = "  ";
                    break;

                case 3:
                    outputLabel.Text = "you jump through the window and run across the fiery landscape, as you start to cross a magma strewn field the ground beneath you caves in, you fall into lava and die. . .";
                    leftButton.Text = "   ";
                    rightButton.Text = "   ";
                    break;

                case 4:
                    outputLabel.Text = "you wander into the hallway and walk down the halls, there are two doors, and you can hear heavy footsteps coming from around the corner";
                    leftButton.Text = "Take the left door?";
                    rightButton.Text = "take the right door?";
                    break;

                case 5:
                    outputLabel.Text = "A large demon comes around the corner, upon spotting you it starts to charge";
                    leftButton.Text = "do you stay and fight?";
                    rightButton.Text = "Or run";
                    //wait ten seconds to activate third path
                    break;

                case 6:
                    outputLabel.Text = "you walk into the left room quickly, and see a demon walk past the doorway you just entered, inside the room is a large sword, embedded in a white stone, there is also a plaque reading 'Only the worthy may wield this blade, all who are not will perish.'";
                    leftButton.Text = "take the sword?";
                    rightButton.Text = "Leave the sword in the stone and continue to the next room";
                    break;

                case 7:
                    outputLabel.Text = "you grasp the hilt of the Holy Sword, your body would tingle slighty, like a leg that had fallen asleep, before erupting into flames. . . you died";
                    break;

                case 8:
                    outputLabel.Text = "you grab the hilt of the sword, and immedietely pain courses through your body, skin smoking and tearing as power coursed through your veins, awakening a force that felt unstoppable, you pain slowly subsided, and te sword came loose from the stone";
                    leftButton.Text = "Continue down the hallway?";
                    rightButton.Text = "Or enter the second room?";
                    break;

                case 9:
                    outputLabel.Text = "you enter the second room you spot a large chest in the centre of the room, like a pirates treasure chest";
                    leftButton.Text = "Loot the chest?";
                    rightButton.Text = "theres no time for loot! get out of here";
                    break;

                case 10:
                    outputLabel.Text = "you approach the chest, and open it, inside is a pile of gold and jewels, as you reach inside the chest the edges of the box grow teeth and jaws, the box would slam shut, biting off your hand, and quickly dispatching you. . . you've been mimicked";
                    leftButton.Text = "   ";
                    rightButton.Text = "   ";
                    break;

                case 11:
                    outputLabel.Text = "As you turn to leave the room, the chest would lunge forward, morphing into a chest with teeth as large as daggers. it attacked you from behind, killing you instantly. . . You've been mimicked.";
                    leftButton.Text = "   ";
                    rightButton.Text = "   ";
                    break;

                case 12:
                    outputLabel.Text = "the demon laughs, Catching you as you charge, and breakes you over its knee like a dry stick. . . you died";
                    leftButton.Text = "   ";
                    rightButton.Text = "   ";
                    break;

                case 13:
                    outputLabel.Text = "you run down the hallway, and vie into the";
                    leftButton.Text = "Left door";
                    rightButton.Text = "right Door";
                    break;

                case 14:
                    outputLabel.Text = "as you enter the right door you see a pool of water, it is reflective and crystal clear, there is a plaque reading 'Ask where or when, but just beware, the pacts now broken cannot be repaired'";
                        leftButton.Text = "Where?";
                    rightButton.Text = "When?";
                    break;

                case 15:
                    outputLabel.Text = "in the pits of hell is where you are, so lost alone, and without a car, you face the crystal pool (me), facing punishment for crimes that are yet to be, to escape a fate that is worse than death, defeat the reaper, and steal his breath \nas the voice echoed around the chamber a second tunnel would appear, laced with crystals of various colors ";
                    leftButton.Text = "Follow the crystal tunnel";
                    rightButton.Text = "go back the way you came";
                    break;

                case 16:
                    outputLabel.Text = "to escape your fate and your inevitable tomb, you must enter the dragons room, slay the beast or take flight, you must escape before tonight";
                    //reveal the timer

                    leftButton.Text = "Do you go back the way you came?";
                    rightButton.Text = "Or the way the demon came from";
                    break;

                case 17:
                    outputLabel.Text = "as you go back the way you came the last thing you hear is an earthshattering roar, as your body is incinerated \n you die";
                    break;

                case 18:
                    outputLabel.Text = "as you walk down the tunnel you see two swords trapped in the stone, one is a black iron blade with skulls and demonic runes embedded in its surface, dark power rippling around its blade \n the second blade is a pale white sword that radiates an aura of calm and peace, the blade itself is unadorned, save for a cross embedded in the hilt, as you look closer words would appear along its edge 'When you draw this blade, draw it not in rage or anger, draw it so that you may lay down the enemies of all that is good";
                    leftButton.Text = "take the demon sword";
                    rightButton.Text = "take the holy sword";
                    break; 

                case 19:
                    outputLabel.Text = "as you hoist the heavy black weapon over your head you feel immense amounts of pain throughout your system, you skin becoming a deep blood red, bat like wings ripping from your back as a crown of horns erupted from your skull, when you recover from the immense pain you recognize your new strength, as you are now a demon";
                    leftButton.Text = "Continue down the hallway";
                    rightButton.Text = "Slaughter your way out of hell";
                    break;

                case 20:
                    outputLabel.Text = "you pull the sword from the stone, and instantly feel sick, you hear you bones breaking and shattering as they shifted around, a white glow would appear just above your brow, and you could feel a slight tingling in your back as the pain stopped, when you look behind you you see two pure white wings, you have been transformed into an angel.";
                    leftButton.Text = "slaughter your way out of hell?";
                    rightButton.Text = "Fly away.";
                    break;

                case 21:
                    outputLabel.Text = "you begin your rampage through hell, slaying devils and demons without mercy or difficulty, but before you make it to the exit a demon gets a lucky shot, impaling you upon his blade, the last thing you see are your wings turning a black shade, as your mind fades as well";
                    break;

                case 22:
                    outputLabel.Text = "you fly uneventfully out of hell, escaping easily \n\n congrats! You have passed the Angelic path, two more bosses remain."; 
                    break;

                case 23:
                    outputLabel.Text = "you enter a room filled up to your waist wit water, some spots you can tell are deeper than others, you fly to escape the gross and murky water, as you rise into the air you spot a draconic head rise from  the water threateningly and hiss, its breath is venomous, and clouds of steam rise from the water, it strikes three times, barely missing each time, on its fourth attack it stumbles, giving you an opportunity to attack";
                    leftButton.Text = "Behead it";
                    rightButton.Text = "Stab it in the foot";
                    break;

                case 24:
                    outputLabel.Text = "you swing the heavy and demonic sword into the creatures neck, beheading it in a single blow \n\nyou float to the ground, having defeated the creature, its corpse sinking below the waterline";
                    leftButton.Text = "Examine the corspe";
                    rightButton.Text = "Look for doors to escape through";
                    break;

                case 25:
                    outputLabel.Text = "you go to examine the corpse, and you turn around to walk over you spot the headless corpse stand up, and its neck splitting into two more headed necks.";
                    leftButton.Text = "Behead it again";
                    rightButton.Text = "stab it in the chest";
                    break;

                case 26:
                    outputLabel.Text = "you stab the hydra in the chest, killing it, as it dies a door appears, as you go through it you wake up in the comfort of your home, safe at last\n\n congrats! You have passed the hydra path, two more bosses remain.";
                    leftButton.Text = "";
                    rightButton.Text = "";

                    break;

                case 27:
                    outputLabel.Text = "you leap into the air, your sword a flashing arc as it beheads the two heads, but once again they split, the beast now has four heads, these four heads all exhale a blast of poison, killing you painfully, and slowly.";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 28:
                    outputLabel.Text = "you begin searching the walls for hidden doors, you fins nothing, but are suddenly distracted by a roar, the corpse has stood up again, having regrown its head, as well as a second one, it strikes from both sides, biting you in half, you die";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 29:
                    outputLabel.Text = "you stab the creatures foot, putting it off balance, it dives back below the water, swirling it with its tail";
                    leftButton.Text = "follow it into the water";
                    rightButton.Text = "Cast Fireball";
                    break;

                case 30:
                    outputLabel.Text = "you dive into the water, almost immediately it bites you in half, you die";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 31:
                    outputLabel.Text = "the water would boil, killing the hydra instantly \n\ncongrats! You have passed the hydra path, two more bosses remain.";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 32:
                    outputLabel.Text = "you go down the hallway, along the way there is a rack of weapons, there is a gun, with many rounds of ammunition, and a sword ";
                    leftButton.Text = "take the gun";
                    rightButton.Text = "take the sword";
                    break;

                case 33:
                    outputLabel.Text = "you walk into the next room, a looming cavern filled with fiery pits and brimstone, sitting upon a bleached white throne, its red skin glinting with dark energy as it watched you curiously, waiting to see how you reacted";
                    leftButton.Text = "run away?";
                    rightButton.Text = "shoot him";
                    break;

                case 34:
                    outputLabel.Text = "you walk into the next room, a looming cavern filled with fiery pits and brimstone, sitting upon a bleached white throne, its red skin glinting with dark energy as it watched you curiously, waiting to see how you reacted";
                    leftButton.Text = "run away";
                    rightButton.Text = "charge him with the sword";
                    break;

                case 35:
                    outputLabel.Text = "as you turn your back on the demon, preparing yourself to run away, the demon lashed out with a flaming whip, cracking it into the back of your neck, the last thing you saw before you died? was the looming face of an elder demon";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 36:
                    outputLabel.Text = "the demon would stumble at the sudden attack, unsurprisingly the demon dies quickly, but you sense that it is not over yet, as a rumbling sound grows louder from behind the throne, an echoing roar shaking the ground below your feet, you feel an aura of terror and fear, before a dragon erupts from the wall of the cavern, boulders fell from the ceiling, threatening to crush you ";
                    leftButton.Text = "roll left";
                    rightButton.Text = "roll Right";
                    break;

                case 37:
                    outputLabel.Text = "you roll directly under a falling boulder, crushing you instantly";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 38:
                    outputLabel.Text = "you get lucky, rolling to the right you barely avoid the falling debris of the crash, you catch a brief glance of red scales, before you are forcefully lifted from the ground, dangling you nearly forty feet off the ground, by nothing more then your torn shirt 'Who dares to disrupt my slumber?'";
                    leftButton.Text = "'Ummm. . . Me?";
                    rightButton.Text = "Shoot it";
                    break;

                case 39:
                    outputLabel.Text = "the dragon would roar in agony as the bullet pierced the beasts eye, rattling around inside its skull the dragon would stumble, fire leaking from its mouth as it went limp and fell to the floor, nearly crushing you beneath its bulk";
                    leftButton.Text = "crawl out from under the dragon";
                    rightButton.Text = "wait for help";
                    break;

                case 40:
                    outputLabel.Text = "the dragon regards you with disgust, before tossing you to the ground and stepping on you, crushing you, you die";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 41:
                    outputLabel.Text = "as you go to move the dragons corpse would shift, pushing its full weight onto you, and instantly crushing you, you die";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 42:
                    outputLabel.Text = "as you wait for help, suddenly the body is lifted away, a rather terrified team of miners would help you up, and quickly take you out through the tunnel tat they had dug, pulling you to freedom.\n\ncongrats! You have passed the dragons path, two more bosses remain.";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 43:
                    outputLabel.Text = "you charge the demon, sword in hand, it takes a step forward, cracking its flaming whip at you, you catch the whip on your blade, reflecting it, as you yank the whip out of the demons whip out of its hands do you \n\ntake the whip and use it against the demon or slice the whip to bits to taunt the demon";
                    leftButton.Text = "Take the whip and use it against him";
                    rightButton.Text = "Cut the whip";
                    break;

                case 44:
                    outputLabel.Text = "as you slice into the magically reinforced whip, the enchantments holding it together would release all of the energy stored inside them, causing a massive explosion, similar to a nuclear bomb \n\nyou died";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 45:
                    outputLabel.Text = "you take the hilt of the whip, and crack it towards the demon, it would lash against the demons chest, and the enchantments in it would turn the demon to stone, as the demons last roar of pain fades a new3 one begins to grow, a low rumbling roar from behind you";
                    leftButton.Text = "turn around";
                    rightButton.Text = "roll away";
                    break;

                case 46:
                    outputLabel.Text = "you turn quickly, the last thing you see are blazing red scales, and an inferno of fire, right before the flames engulf you, killing you instantly";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 47:
                    outputLabel.Text = "you feel a blast of heat on your side as you roll, turning around in the same movement you see a large red dragon, its frill and spines burning with an intense heat, and just where you were before, the floor had been melted to magma. \n\nyou charge the dragon, deciding that surprise was the top tactic, do you \n\nstab the neck? \n\nor go for a decapitation";
                    leftButton.Text = "stab the neck";
                    rightButton.Text = "decapitate";
                    break;

                case 48:
                    outputLabel.Text = "you sheathe your blade in the creatures neck, killing it instantly \n\nas soon as you slay the beast a golden doorway appears, as you enter the door you find yourself in the comfort of your home, safe and sound at last. . . congrats! You have passed the dragons path, two more bosses remain.";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 49:
                    outputLabel.Text = "you charge the beast, running alongside it as it turns its breath, melting the floor behind you, you would go for the swing at its head, but the blade would bounce off its thick scales, doing no harm";
                    leftButton.Text = "stab the eye";
                    rightButton.Text = "do it again";
                    break;

                case 50:
                    outputLabel.Text = "the blade sinks into the soft tissue of the dragons eye, burying it up to its hilt in the dragons soft brain tissues with a sickening sucking sound";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 51:
                    outputLabel.Text = "the blade sticks into the scales of the beast, becoming stuck, as you try to pull the blade out you are stepped on by the dragon, dying instantly";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 52: 
                    outputLabel.Text = "";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 53:
                    outputLabel.Text = "";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 54:
                    outputLabel.Text = "";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 55:
                    outputLabel.Text = "";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 56:
                    outputLabel.Text = "";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 57:
                    outputLabel.Text = "";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 58:
                    outputLabel.Text = "";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 59:
                    outputLabel.Text = "";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

                case 60:
                    outputLabel.Text = "";
                    leftButton.Text = "";
                    rightButton.Text = "";
                    break;

            }
        }
    }
    
}
