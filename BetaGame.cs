﻿internal class BetaGame
{
    private static void Main()
    {
        VirtualTerminal.VirtualTerminal terminal = new("user");
        terminal.Run();
    }
}