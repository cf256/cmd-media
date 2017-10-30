using WindowsInput;
namespace Play
{
    class Program
    {
        static int Main(string[] args)
        {

            if (args.Length == 0)
            {
                return 0;
            }

            var input = args[0].ToLower();
            var simulator = new InputSimulator().Keyboard;

            switch (input)
            {
                case "play":
                case "pause":
                    simulator.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE);
                    break;
                case "next":
                    simulator.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK);
                    break;
                case "prev":
                    simulator.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK);
                    simulator.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK);
                    break;
                default:
                    break;
            }

            return 0;
        }
    }
}
