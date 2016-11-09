using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Freddy_Fazbear_Entertainment_Console
{
    class Program
    {
        static string name, pwd;
        static int loginas = 0;
        static string path = "A:\\>";

        static string[] namelist = new string[3] { "em_01", "em_02", "em_06" };
        static string[] pwdlist = new string[3] { "AcM3d@a_3dva", "iAmStILla1iV3", "em_06" };
        static int[] permisnLvl = new int[3] { 3, 2, 1 };

        static string fr = "Freddy";
        static string bo = "Bonnie";
        static string fo = "Foxy";
        static string ch = "Chica";
        static bool leftdoorison = true;
        static bool rightdoorison = true;
        
        static string[,] caminfo=new string[,]{{"Show Stage","4"},
                                               {"Dining Area","3"},
                                               {"Pirate Cove","2"},
                                               {"West Hall","1"},
                                               {"Supply Closet","1"},
                                               {"East Hall","1"},
                                               {"Back Stage","3"},
                                               {"Kitchen","3"},
                                               {"Toilets","3"}};
        static int fr_d = 4;
        static int bo_d = 4;
        static int ch_d = 4;
        static int fo_d = 2;

        static int isanimatronicmovementstart = 0;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "One Night Of Freddy's SIMULATOR by Patrick Wu";

            Console.WriteLine("****WELCOME TO FREDDY FAZBEAR'S PIZZARIA*****");
            Console.WriteLine("Thanks for joining Fazbear Entertainment.");
            Console.WriteLine("-----WHAT TO DO-----");
            Console.WriteLine("YOU should launch the console by entering FAZ_ENT in disk operating system.");
            Console.WriteLine("Your account is em_06 with the same password.");
            Console.WriteLine("Please CHANGE your password after you log in.");
            Console.WriteLine("");
            Console.WriteLine("Enjoy your night watch!");
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.Title = "Microsoft (R) DOS Version 5.0a";
            Console.WriteLine("Booting From Drive A...");
            Thread.Sleep(5000);
            Console.WriteLine("");
            Console.WriteLine("Starting MS-DOS...");
            Thread.Sleep(5000);
            Console.WriteLine("");           
            Console.WriteLine("HIMEM: DOS XMS Driver, Version 2.78 - 09/19/91");
            Console.WriteLine("XMS Specification Version 2.0");
            Console.WriteLine("Copyright 1988-1991 Microsoft Corp.");
            Console.WriteLine("");
            Console.WriteLine("Installed A20 Handler number 2.");
            Console.WriteLine("64K High Memory Area is available.");
            Console.WriteLine("");
            Console.WriteLine("DVR is detected.");
            Console.WriteLine("AlxDvr_V101_SZ1C3.COM Installed.");
            Console.WriteLine("");
            Console.WriteLine("Microsoft (R) MS-DOS (R) Version 5.0a\n"+
                              "(C) Copyright Microsoft Corp 1981-1993");
            Console.WriteLine("");
            Console.Write("A:\\>");
            while (true)
            {
                try
                {
                    string abouttoread = Console.ReadLine();
                    switch (abouttoread)
                    {
                        case "exit":
                            Ex();
                            break;
                        case "cls":
                        case "CLS":
                            clr();
                            break;
                        case "cd A:\\":
                        case "CD A:\\":
                        case "cd A:\\FAZ_ENT_COM":
                        case "CD A:\\FAZ_ENT_COM":
                        case "cd FAZ_ENT_COM":
                        case "CD FAZ_ENT_COM":
                        case "cd ..":
                        case "CD ..":
                            cd(abouttoread);
                            break;
                        case "dir":
                        case "DIR":
                            if (path == "A:\\FAZ_ENT_COM>")
                            {
                                dir_fec();
                            }
                            else
                            {
                                dir();
                            }
                            
                            break;
                        case "dir FAZ_ENT_COM":
                        case "DIR FAZ_ENT_COM":
                            if (path == "A:\\FAZ_ENT_COM>")
                            {
                                Console.WriteLine("    Volume in Dirve A is MSD50aBD");
                                Console.WriteLine("");
                                Console.WriteLine("Folder NOT FOUND.");
                                Console.Write(path);
                            }
                            else
                            {
                                dir_fec();
                            }
                            break;
                        case "dir A:\\FAZ_ENT_COM":
                        case "DIR A:\\FAZ_ENT_COM":                         
                                dir_fec();
                            break;
                        case "FAZ_ENT.COM":
                        case "FAZ_ENT":
                            if (path != "A:\\FAZ_ENT_COM>")
                            {
                                fec();
                            }    
                            break;
                        case "COMMAND.COM":
                        case "COMMAND":
                        case "FDISK.COM":
                        case "FDISK":
                        case "FORMAT.COM":
                        case "FORMAT":
                            Console.WriteLine("ERR:FILE FAIL TO LAUNCH.");
                            break;
                        default:
                            Console.WriteLine(abouttoread+" is not recognized as an internal or external command, operable program or drive file.");
                            Console.Write(path);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An ERROR occurs.Please type again." + ex.Message);
                }
            }
      
        }

        static void cd(string data)
        {
            switch (data)
            {
                case "cd A:\\":
                case "CD A:\\":
                case "cd ..":
                case "CD ..":
                    path = "A:\\>";
                    break;
                case "cd A:\\FAZ_ENT_COM":
                case "CD A:\\FAZ_ENT_COM":
                    path = "A:\\FAZ_ENT_COM>";
                    break;
                case "cd FAZ_ENT_COM":
                case "CD FAZ_ENT_COM":
                    if (path == "A:\\>")
                    {
                        path = "A:\\FAZ_ENT_COM>";
                    }
                    else
                    {
                        Console.WriteLine("Folder NOT FOUND.");
                    }
                    break;
            }
            Console.Write(path);
        }
        static void dir()
        {
            Console.WriteLine("    Volume in Dirve A is MSD50aBD\n" +
                                  "    Directory of A:\\");
            Console.WriteLine("");
            Console.WriteLine("FAZ_ENT_COM");
            Console.WriteLine("COMMAND\tCOM\t95308\t2-02-88\t12:00a");
            Console.WriteLine("FAZ_ENT\tCOM\t10121\t5-19-90\t2:01p");
            Console.WriteLine("FDISK\tCOM\t55029\t8-08-88\t8:39p");
            Console.WriteLine("FORMAT\tCOM\t11908\t7-13-88\t2:04p");
            Console.WriteLine("SYS\tCOM\t4921\t7-13-88\t4:25p");
            Console.WriteLine("          5 File(s) 1 Folder(s)   1141108 bytes free");
            Thread.Sleep(800);
            Console.Write(path);
        }
        static void dir_fec()
        {
            
            Console.WriteLine("    Volume in Dirve A is MSD50aBD\n" +
                                  "    Directory of A:\\FAZ_ENT_COM");
            Console.WriteLine("");
            Console.WriteLine("AlxDvr_V101_SZ1C3\tCOM\t32321\t5-19-90\t2:01p");
            Console.WriteLine("DATA_B\tDB\t11212\t11-11-93\t8:23a");
            Console.WriteLine("NT_CPRESS\tDLL\t41602\t5-19-90\t2:01p");
            Console.WriteLine("UCDS\tCOM\t11908\t5-19-90\t2:01p");
            Console.WriteLine("          4 File(s)   1141108 bytes free");
            Thread.Sleep(800);
            Console.Write(path);
        }
        static void fec()
        {
            Console.WriteLine("Starting FAZ_ENT.COM...");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("AlxDvr_V101_SZ1C3.COM Loaded");
            Thread.Sleep(800);
            Console.WriteLine("UCDS.COM Loaded");
            Thread.Sleep(800);
            Console.WriteLine("NT_CPress.DLL Loaded");
            Console.WriteLine("");
            Thread.Sleep(800);
            Console.WriteLine("CCTV is initializing...");
            Thread.Sleep(6000);
            Console.WriteLine("Success.");
            Thread.Sleep(800);
            Console.WriteLine("");
            Console.WriteLine("Crime Detection System Version 1.1");
            Console.WriteLine("Connecting US Police Force Crime DATABASE...");
            Thread.Sleep(5500);
            Console.WriteLine("Success.");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Fazbear Entertainment (R) Console Version 2.1.0";
            Console.WriteLine("Fazbear Entertainment Console 2.1.0");
            Console.WriteLine("****************************");
            Console.WriteLine("Hello there, welcome to the Fazbear Entertainment Console!");
            Console.WriteLine("The date is 07/14/1993");
            Console.WriteLine("****************************");

            Console.Write("usename:");
            name = Console.ReadLine().ToString();
            Console.Write("password:");
            pwd = Console.ReadLine().ToString();
            if (name == namelist[2] && pwd == pwdlist[2])
            {
                loginas = 3;
                Console.WriteLine("");
                Console.WriteLine("Welcome em_06");
                Console.WriteLine("");
                Console.WriteLine("NAME:Mike Schmidt");
                Console.WriteLine("STAGE:Night Security Guard");
            }
            else if (name == namelist[0] && pwd == pwdlist[0])
            {
                loginas = 1;
                Console.WriteLine("");
                Console.WriteLine("Welcome em_01");
                Console.WriteLine("");
                Console.WriteLine("Administrator");
                Console.WriteLine("STAGE:Top Manager");
                Console.WriteLine("DEBUG MODE ON");
            }
            else if (name == namelist[1] && pwd == pwdlist[1])
            {
                loginas = 2;
                Console.WriteLine("");
                Console.WriteLine("Welcome em_02");
                Console.WriteLine("");
                Console.WriteLine("NAME:Danid*dh23kjskJX&sgUUSffa");
                Thread.Sleep(1000);
                Console.WriteLine("STA---ERR:E0x019871(SYSTEM_CORE_ERR)\n");
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.Red;
                int rdm=0;
                while(rdm<300)
                {
                    rdm++;
                    Console.WriteLine(GetRandomString(70));
                    Thread.Sleep(50);
                }
                Console.WriteLine("SYST--Ad----1-23%^3_POWExad--ERR:EXPECTION_NONE");
                Thread.Sleep(5000);
                Console.WriteLine("");
                Console.WriteLine(""); 
                Console.WriteLine(""); 
                Console.WriteLine("");
                Console.WriteLine("");
                Thread.Sleep(5000);
                Console.Write("i  T    's");
                Thread.Sleep(2000);
                Console.Write("  M    e");
                Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("ERROR:WRONG USERNAME/PASSWORD.The console will exit.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            fec_com();
            
        }
        static void clr()
        {
            Console.Clear();
            Console.Write(path);
        }
        static void Ex()
        {
            Console.WriteLine("");
            DateTime currdt = DateTime.Now.AddMilliseconds(300);
            DateTime nowdt = DateTime.Now;
            while (nowdt < currdt)
            {
                nowdt = DateTime.Now;
            }
            Environment.Exit(0);
        }

        static void fec_com()
        {
            Console.WriteLine("");
            Console.WriteLine("CDS Database Version: 1.0.10342 Released in 1992");
            Console.WriteLine("DVR Driver Version:UNDETECTED");
            Console.WriteLine("");
            Console.WriteLine("Please enter a number for a function");
            Console.WriteLine("****************************");
            Console.WriteLine("1:CCTV");
            Console.WriteLine("2:Door System");
            Console.WriteLine("3:Password Change");
            Console.WriteLine("4:Exit");
            if (permisnLvl[loginas-1]==3)
            {
                Console.WriteLine("***********Extra************");
                Console.WriteLine("5:CDS Set-up");
                Console.WriteLine("6:Password Management");
                Console.WriteLine("7:Animatronic Management");
            }
            else if (permisnLvl[loginas-1] == 2)
            {
                Console.WriteLine("***********Extra************");
                Console.WriteLine("5:CDS Set-up");
            }
            Console.Write(">");
            while (true)
            {
                try
                {
                    int n = 0;
                    n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Cam();
                            break;
                        case 2:
                            Door();
                            break;
                        case 3:
                            PwdCh();
                            break;
                        case 4:
                            loginas = 0;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.Title = "Microsoft (R) DOS Version 5.0a";
                            Console.Write(path);
                            return;
                        case 5:
                            if (permisnLvl[loginas-1]==2)
                            {
                                Setup();
                            }
                            break;
                        case 6:
                            if (permisnLvl[loginas - 1] ==3)
                            {
                                PwdManagmt();
                            }
                            break;
                        case 7:
                            if (permisnLvl[loginas - 1] ==3)
                            {
                                am();
                            }
                            break;
                        default:
                            Console.WriteLine("ERROR:INVALID INPUT.Please type again");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An ERROR occurs.Please type again." + ex.Message);
                    Console.Write(">");
                }
            }
        }

        static void Cam()
        {
            Console.WriteLine("");
            Console.WriteLine("Please select a camera...");
            Console.WriteLine("****************************");
            Console.WriteLine("Cams:");
            Console.WriteLine("1:Show Stage");
            Console.WriteLine("2:Dining Area");
            Console.WriteLine("3:Pirate Cove");
            Console.WriteLine("4:Back Stage");
            Console.WriteLine("5:Toilets");
            Console.WriteLine("6:West Hall");
            Console.WriteLine("7:East Hall");
            Console.WriteLine("8:Supply Closet");
            Console.WriteLine("9:Kitchen");
            Console.WriteLine("To scan all, type SCAN");
            Console.WriteLine("To exit, type EXIT");
            Console.Write(">");
            while (true)
            {
                try
                {

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Camreact(caminfo[0, 0], fr, bo, ch);
                            Console.Write(">");
                            break;
                        case "2":
                            Camreact(caminfo[1, 0], false);
                            Console.Write(">");
                            break;
                        case "3":
                            Camreact(caminfo[2, 0], fo);
                            Console.Write(">");
                            break;
                        case "4":
                            Camreact(caminfo[6, 0], false);
                            Console.Write(">");
                            break;
                        case "5":
                            Camreact(caminfo[8, 0], false);
                            Console.Write(">");
                            break;
                        case "6":
                            Camreact(caminfo[3, 0], false);
                            Console.Write(">");
                            break;
                        case "7":
                            Camreact(caminfo[5, 0], false);
                            Console.Write(">");
                            break;
                        case "8":
                            Camreact(caminfo[4, 0], false);
                            Console.Write(">");
                            break;
                        case "9":
                            Camreact(caminfo[7,0], true);
                            Console.Write(">");
                            break;
                        case "SCAN":
                            Camreact(caminfo[0, 0], fr, bo, ch);
                            Camreact(caminfo[1, 0], false);
                            Camreact(caminfo[2, 0], fo);
                            Camreact(caminfo[6, 0], false);
                            Camreact(caminfo[8, 0], false);
                            Camreact(caminfo[3, 0], false);
                            Camreact(caminfo[5, 0], false);
                            Camreact(caminfo[4, 0], false);
                            Camreact(caminfo[7, 0], true);
                            Console.Write(">");
                            return;
                        case "EXIT":
                            fec_com();
                            return;
                        default:
                            Console.Write(">");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An ERROR occurs.Please type again." + ex.Message);
                }
            }
        }
        static void Door()
        {
            Console.WriteLine("");
            Console.WriteLine("ASUM Security Door System");
            Console.WriteLine("****************************");
            Console.WriteLine("HELP");
            Console.WriteLine("  -[Door] [COMMAND]");
            Console.WriteLine("  -EXAMPLE:");
            Console.WriteLine("  |To open the left door,type L ON");
            Console.WriteLine("  |To close the right door,type R OFF");
            Console.WriteLine("  -To exit, type EXIT");
            Console.Write(">");
            while (true)
            {
                try
                {

                    switch (Console.ReadLine())
                    {
                        case "L ON":
                            if (leftdoorison == false)
                            {
                                leftdoorison = true;
                                Console.WriteLine("Left door is opened.");
                            }
                            else
                            {
                                Console.WriteLine("Left door is already opened.");
                            }
                            Console.Write(">");
                            break;
                        case "L OFF":
                            if (leftdoorison == true)
                            {
                                leftdoorison = false;
                                Console.WriteLine("Left door is closed.");
                            }
                            else
                            {
                                Console.WriteLine("Left door is already closed.");
                            }
                            Console.Write(">");
                            break;
                        case "R ON":
                            if (rightdoorison == false)
                            {
                                rightdoorison = true;
                                Console.WriteLine("Right door is opened.");
                            }
                            else
                            {
                                Console.WriteLine("Right door is already opened.");
                            }
                            Console.Write(">");
                            break;
                        case "R OFF":
                            if (rightdoorison == true)
                            {
                                rightdoorison = false;
                                Console.WriteLine("Right door is closed.");
                            }
                            else
                            {
                                Console.WriteLine("Right door is already closed.");
                            }
                            Console.Write(">");
                            break;
                        case "EXIT":
                            fec_com();
                            return;
                        default:
                            Console.Write(">");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An ERROR occurs.Please type again." + ex.Message);
                }
            }
        }
        static void Setup()
        {

        }
        static void PwdCh()
        {
            Console.WriteLine("");
            Console.Write("Please Type your new password:");
            pwdlist[loginas-1] = Console.ReadLine();
            Console.Write("Password change success.\nThe console will restart in 3 seconds.");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            fec();

        }
        static void PwdManagmt()
        {

        }
        static void am()
        {

        }
        
        static void Camreact(string cam, bool ErrORnull)
        {
            string a;
            Console.WriteLine("Scanning...");
            Thread.Sleep(3000);
            if(ErrORnull)
            {
                Console.WriteLine(" CAM {0} ERR:SIGNAL LOST.\nCode:E0x88CE88 (DVR_SIGNAL_UNDECTED)",cam);
            }
            else
            {
                Console.WriteLine("No animatronics found in {0}.",cam);
            }
            
            
        }
        static void Camreact(string cam, string a)
        {
            Console.WriteLine("Scanning...");
            Thread.Sleep(3000);
            Console.WriteLine("Animatronics found in {0}: {1}", cam, a);
        }
        static void Camreact(string cam, string a,string b)
        {
            Console.WriteLine("Scanning...");
            Thread.Sleep(3000);
            Console.WriteLine("Animatronics found in {0}: {1}, {2}", cam, a, b);
        }
        static void Camreact(string cam, string a, string b,string c)
        {
            Console.WriteLine("Scanning...");
            Thread.Sleep(3000);
            Console.WriteLine("Animatronics found in {0}: {1}, {2}, {3}", cam, a, b, c);
        }
           
        private static Random random = new Random();
        static public string GetRandomString(int len)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, len)
                        .Select(s => s[random.Next(s.Length)]).ToArray());
        }           
    }
}

