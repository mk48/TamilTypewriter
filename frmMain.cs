using Microsoft.VisualBasic;

namespace TamilTypewriter
{
    public partial class frmMain : Form
    {
        private KEY pKey;

        public frmMain()
        {
            InitializeComponent();
        }

        private void txtBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!chkTamilOn.Checked)
            {
                return;
            }


            switch (pKey)
            {
                case KEY.க்:
                    {
                        SendKeys.Send(GETKEY(e.KeyChar).ToString());
                        SendKeys.Send(Strings.ChrW(3021).ToString());
                        pKey = KEY.NO;
                        e.Handled = true;
                        break;
                    }
                // Case KEY.ThunaiEazhuthu
                case KEY.கி:
                    {
                        SendKeys.Send(GETKEY(e.KeyChar).ToString());
                        SendKeys.Send(Strings.ChrW(3007).ToString());
                        pKey = KEY.NO;
                        e.Handled = true;
                        break;
                    }
                case KEY.கீ:
                    {
                        SendKeys.Send(GETKEY(e.KeyChar).ToString());
                        SendKeys.Send(Strings.ChrW(3008).ToString());
                        pKey = KEY.NO;
                        e.Handled = true;
                        break;
                    }
                case KEY.கு:
                    {
                        SendKeys.Send(GETKEY(e.KeyChar).ToString());
                        SendKeys.Send(Strings.ChrW(3009).ToString());
                        pKey = KEY.NO;
                        e.Handled = true;
                        break;
                    }
                case KEY.கூ:
                    {
                        SendKeys.Send(GETKEY(e.KeyChar).ToString());
                        SendKeys.Send(Strings.ChrW(3010).ToString());
                        pKey = KEY.NO;
                        e.Handled = true;
                        break;
                    }
                case KEY.கெ:
                    {
                        SendKeys.Send(GETKEY(e.KeyChar).ToString());
                        SendKeys.Send(Strings.ChrW(3014).ToString());
                        pKey = KEY.NO;
                        e.Handled = true;
                        break;
                    }
                case KEY.கே:
                    {
                        SendKeys.Send(GETKEY(e.KeyChar).ToString());
                        SendKeys.Send(Strings.ChrW(3015).ToString());
                        pKey = KEY.NO;
                        e.Handled = true;
                        break;
                    }
                case KEY.கை:
                    {
                        SendKeys.Send(GETKEY(e.KeyChar).ToString());
                        SendKeys.Send(Strings.ChrW(3016).ToString());
                        pKey = KEY.NO;
                        e.Handled = true;
                        break;
                    }
                case KEY.கொ:
                    {
                        break;
                    }

                case KEY.NO:
                    {
                        switch (e.KeyChar)
                        {
                            case 'a':
                                {
                                    e.KeyChar = Strings.ChrW(2991);
                                    break;
                                }
                            case 'c':
                                {
                                    e.KeyChar = Strings.ChrW(2953);
                                    break;
                                }
                            case 'd':
                                {
                                    e.KeyChar = Strings.ChrW(2985);
                                    break;
                                }
                            case 'e':
                                {
                                    e.KeyChar = Strings.ChrW(2984);
                                    break;
                                }
                            case 'f':
                                {
                                    e.KeyChar = Strings.ChrW(2965);
                                    break;
                                }
                            case 'g':
                                {
                                    e.KeyChar = Strings.ChrW(2986);
                                    break;
                                }
                            case 'h':
                                {
                                    // pKey = KEY.ThunaiEazhuthu
                                    e.KeyChar = Strings.ChrW(3006);
                                    break;
                                }
                            case 'j':
                                {
                                    e.KeyChar = Strings.ChrW(2980);
                                    break;
                                }
                            case 'k':
                                {
                                    e.KeyChar = Strings.ChrW(2990);
                                    break;
                                }
                            case 'l':
                                {
                                    e.KeyChar = Strings.ChrW(2975);
                                    break;
                                }
                            case 'm':
                                {
                                    e.KeyChar = Strings.ChrW(2949);
                                    break;
                                }
                            case 'o':
                                {
                                    SendKeys.Send(Strings.ChrW(2975).ToString());
                                    SendKeys.Send(Strings.ChrW(3007).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'r':
                                {
                                    e.KeyChar = Strings.ChrW(2970);
                                    break;
                                }
                            case 's':
                                {
                                    e.KeyChar = Strings.ChrW(2995);
                                    break;
                                }
                            case 't':
                                {
                                    e.KeyChar = Strings.ChrW(2997);
                                    break;
                                }
                            case 'u':
                                {
                                    e.KeyChar = Strings.ChrW(2992);
                                    break;
                                }
                            case 'v':
                                {
                                    e.KeyChar = Strings.ChrW(2958);
                                    break;
                                }
                            case 'w':
                                {
                                    e.KeyChar = Strings.ChrW(2993);
                                    break;
                                }
                            case 'x':
                                {
                                    e.KeyChar = Strings.ChrW(2962);
                                    break;
                                }
                            case 'y':
                                {
                                    e.KeyChar = Strings.ChrW(2994);
                                    break;
                                }
                            case 'z':
                                {
                                    e.KeyChar = Strings.ChrW(2979);
                                    break;
                                }


                            case 'b':
                                {
                                    pKey = KEY.கெ;
                                    e.Handled = true;
                                    break;
                                }
                            case 'i':
                                {
                                    pKey = KEY.கை;
                                    e.Handled = true;
                                    break;
                                }
                            case 'n':
                                {
                                    pKey = KEY.கே;
                                    e.Handled = true;
                                    break;
                                }
                            case 'p':
                                {
                                    pKey = KEY.கி;
                                    e.Handled = true;
                                    break;
                                }
                            case '{':
                                {
                                    pKey = KEY.கூ;
                                    e.Handled = true;
                                    break;
                                }
                            case '[':
                                {
                                    pKey = KEY.கு;
                                    e.Handled = true;
                                    break;
                                }
                            case ';':
                                {
                                    pKey = KEY.க்;
                                    e.Handled = true;
                                    break;
                                }
                            case 'P':
                                {
                                    pKey = KEY.கீ;
                                    e.Handled = true;
                                    break;
                                }
                            case '\\':
                                {
                                    e.KeyChar = Strings.ChrW(2999);
                                    break;
                                }
                            case '~':
                                {
                                    e.KeyChar = Strings.ChrW(2947);
                                    break;
                                }
                            case '!':
                                {
                                    e.KeyChar = Strings.ChrW(3000);
                                    break;
                                }
                            case '#':
                                {
                                    e.KeyChar = Strings.ChrW(2972);
                                    break;
                                }
                            case ':':
                                {
                                    e.KeyChar = Strings.ChrW(2969);
                                    break;
                                }
                            case '\'':
                                {
                                    e.KeyChar = Strings.ChrW(2974);
                                    break;
                                }
                            case ',':
                                {
                                    e.KeyChar = Strings.ChrW(2951);
                                    break;
                                }
                            case '<':
                                {
                                    e.KeyChar = Strings.ChrW(2952);
                                    break;
                                }

                            // ******************CAPITAL LETTERS
                            case 'A':
                                {
                                    e.KeyChar = Strings.ChrW(3001);
                                    break;
                                }
                            case 'C':
                                {
                                    e.KeyChar = Strings.ChrW(2954);
                                    break;
                                }
                            case 'D':
                                {
                                    SendKeys.Send(Strings.ChrW(2985).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'E':
                                {
                                    SendKeys.Send(Strings.ChrW(2984).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'F':
                                {
                                    SendKeys.Send(Strings.ChrW(2965).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'G':
                                {
                                    SendKeys.Send(Strings.ChrW(2996).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'H':
                                {
                                    e.KeyChar = Strings.ChrW(2996);
                                    break;
                                }
                            case 'I':
                                {
                                    e.KeyChar = Strings.ChrW(2960);
                                    break;
                                }
                            case 'J':
                                {
                                    SendKeys.Send(Strings.ChrW(2980).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'K':
                                {
                                    SendKeys.Send(Strings.ChrW(2990).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'L':
                                {
                                    SendKeys.Send(Strings.ChrW(2975).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'M':
                                {
                                    e.KeyChar = Strings.ChrW(2950);
                                    break;
                                }
                            case 'N':
                                {
                                    SendKeys.Send(Strings.ChrW(2970).ToString());
                                    SendKeys.Send(Strings.ChrW(3010).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'O':
                                {
                                    SendKeys.Send(Strings.ChrW(2975).ToString());
                                    SendKeys.Send(Strings.ChrW(3008).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'R':
                                {
                                    SendKeys.Send(Strings.ChrW(2970).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'S':
                                {
                                    SendKeys.Send(Strings.ChrW(2995).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'T':
                                {
                                    SendKeys.Send(Strings.ChrW(2997).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'U':
                                {
                                    SendKeys.Send(Strings.ChrW(2992).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'V':
                                {
                                    e.KeyChar = Strings.ChrW(2959);
                                    break;
                                }
                            case 'W':
                                {
                                    SendKeys.Send(Strings.ChrW(2993).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'X':
                                {
                                    e.KeyChar = Strings.ChrW(2963);
                                    break;
                                }
                            case 'Y':
                                {
                                    SendKeys.Send(Strings.ChrW(2994).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }
                            case 'Z':
                                {
                                    SendKeys.Send(Strings.ChrW(2979).ToString());
                                    SendKeys.Send(Strings.ChrW(3009).ToString());
                                    e.Handled = true;
                                    break;
                                }

                        }

                        break;
                    }
            }

        }

        private static char GETKEY(char keychar)
        {
            switch (keychar)
            {
                case 'a':
                    {
                        return Strings.ChrW(2991);
                    }
                case 'c':
                    {
                        return Strings.ChrW(2953);
                    }
                case 'd':
                    {
                        return Strings.ChrW(2985);
                    }
                case 'e':
                    {
                        return Strings.ChrW(2984);
                    }
                case 'f':
                    {
                        return Strings.ChrW(2965);
                    }
                case 'g':
                    {
                        return Strings.ChrW(2986);
                    }
                case 'h':
                    {
                        // pKey = KEY.ThunaiEazhuthu
                        return Strings.ChrW(3006);
                    }
                case 'j':
                    {
                        return Strings.ChrW(2980);
                    }
                case 'k':
                    {
                        return Strings.ChrW(2990);
                    }
                case 'l':
                    {
                        return Strings.ChrW(2975);
                    }
                case 'm':
                    {
                        return Strings.ChrW(2949);
                    }
                case 'r':
                    {
                        return Strings.ChrW(2970);
                    }
                case 's':
                    {
                        return Strings.ChrW(2995);
                    }
                case 't':
                    {
                        return Strings.ChrW(2997);
                    }
                case 'u':
                    {
                        return Strings.ChrW(2992);
                    }
                case 'v':
                    {
                        return Strings.ChrW(2958);
                    }
                case 'w':
                    {
                        return Strings.ChrW(2993);
                    }
                case 'x':
                    {
                        return Strings.ChrW(2962);
                    }
                case 'y':
                    {
                        return Strings.ChrW(2994);
                    }
                case 'z':
                    {
                        return Strings.ChrW(2979);
                    }
                case '\\':
                    {
                        return Strings.ChrW(2999);
                    }
                case '~':
                    {
                        return Strings.ChrW(2947);
                    }
                case '#':
                    {
                        return Strings.ChrW(2972);
                    }
                case '"':    // "
                    {
                        return Strings.ChrW(2974);
                    }
                case ',':
                    {
                        return Strings.ChrW(2951);
                    }
                case '<':
                    {
                        return Strings.ChrW(2952);
                    }
                case 'A':
                    {
                        return Strings.ChrW(3001);
                    }
                case 'H':
                    {
                        return Strings.ChrW(2996);
                    }

                case '!':
                    {
                        return Strings.ChrW(3000);
                    }
                case ':':
                    {
                        return Strings.ChrW(2969);
                    }
            }

            return default;

        }

    }
}