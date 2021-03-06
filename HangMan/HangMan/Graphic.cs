using System;
using System.Collections.Generic;
using System.Text;

namespace HangMan
{
    internal class Graphic
    {
        #region [Hangmantxt]
        public string[] Hangmantxt = 
        { @"
             _                                             
            | |                                            
            | |__   __ _ _ __   __ _ _ __ ___   __ _ _ __  
            | '_ \ / _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
            | | | | (_| | | | | (_| | | | | | | (_| | | | |
            |_| |_|\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                                __/ |                      
                               |___/ 
           " 
        };
        #endregion

        #region [HangmanShape]

        public string[] HangmanShaps =
        {
            @"   ╔═════╗" + '\n' +
            @"   |     ║" + '\n' +
            @"         ║" + '\n' +
            @"         ║" + '\n' +
            @"         ║" + '\n' +
            @"  ▅▅▅▅▅  ║" + '\n',

            @"   ╔═════╗" + '\n' +
            @"   |     ║" + '\n' +
            @"   0     ║" + '\n' +
            @"         ║" + '\n' +
            @"         ║" + '\n' +
            @"  ▅▅▅▅▅  ║" + '\n',

            @"   ╔═════╗" + '\n' +
            @"   |     ║" + '\n' +
            @"   0     ║" + '\n' +
            @"   |     ║" + '\n' +
            @"         ║" + '\n' +
            @"  ▅▅▅▅▅  ║" + '\n',

            @"   ╔═════╗" + '\n' +
            @"   |     ║" + '\n' +
            @"   0     ║" + '\n' +
            @"  /|     ║" + '\n' +
            @"         ║" + '\n' +
            @"  ▅▅▅▅▅  ║" + '\n',

            @"   ╔═════╗" + '\n' +
            @"   |     ║" + '\n' +
            @"   0     ║" + '\n' +
            @"  /|\    ║" + '\n' +
            @"         ║" + '\n' +
            @"  ▅▅▅▅▅  ║" + '\n',

            @"   ╔═════╗" + '\n' +
            @"   |     ║" + '\n' +
            @"   0     ║" + '\n' +
            @"  /|\    ║" + '\n' +
            @"  /      ║" + '\n' +
            @"  ▅▅▅▅▅  ║" + '\n',

            @"   ╔═════╗" + '\n' +
            @"   |     ║" + '\n' +
            @"   0     ║" + '\n' +
            @"  /|\    ║" + '\n' +
            @"  / \    ║" + '\n' +
            @"  ▅▅▅▅▅  ║" + '\n',
        };

        #endregion

    }
}
