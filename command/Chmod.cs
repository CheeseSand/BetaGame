namespace VirtualTerminal.Commands
{
    public class ChmodCommand : VirtualTerminal.ICommand
    {
        public void Execute(string[] args, VirtualTerminal VT)
        {
            
        }

        public string Description(bool detail)
        {
            return "chmod - ������ ���� ����";
        }
    }
}