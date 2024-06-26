namespace VirtualTerminal.Errors{
    public class ErrorsMassage
    {
        public static string NoSuchForD(string command, string comment)
        {
            return $"{command}:{comment}: 그런 파일이나 디렉터리가 없습니다";
        }

        public static string PermissionDenied(string command, string comment)
        {
            return $"{command}:{comment}: 권한 부족";
        }

        public static string NotD(string command, string comment)
        {
            return $"{command}:{comment}: 디렉터리가 아닙니다";
        }

        public static string NotF(string command, string comment)
        {
            return $"{command}:{comment}: 파일이 아닙니다";
        }

        public static string FExists(string command, string comment)
        {
            return $"{command}:{comment}: 파일이 이미 있습니다";
        }

        public static string DNotEmpty(string command, string comment){
            return $"{command}:{comment}: 디렉터리가 비어어있지 않습니다";
        }

        public static string DefaultErrorComment(string input){
            return $" {input}";
        }
    }
}