namespace FunctionalBranchExample
{
    public class Program : IConsoleThing
    {
        static void Main(string[] args)
        {
            //This is the entry point. The other "Main" methods aren't static,
            //so the CLR (.NET runtime environment) can't use them automatically.

            //Look at the first command-line arg. Pick something to execute based on that.
            //If there are no args, use this class's Main() as the default.
            IConsoleThing thingToRun=null;
            if (args.Length>0) {
                if (args[0]=="alt"/*or whatever flag you like!*/)
                {
                    thingToRun = new OtherOption();
                }
                args = removeFirstArg(args);
            }
            if (thingToRun == null) {
                //If we didn't manage to initialise up to here, use the default
                thingToRun = new Program();
            }
            thingToRun.Main(args);
        }
        private static string[] removeFirstArg(string[] args)
        {
            string[] newArgs = new string[args.Length-1];
            Array.Copy(args, 1, newArgs, 0, newArgs.Length);
            return newArgs;
        }

        /// <summary>
        /// Do this Program's default console behaviour.
        /// </summary>
        /// <param name="args">Command-line args</param>
        /// <remarks>
        /// This is an unusual way of declaring a method. It's an "explicit" implementation of the IConsoleThing's Main method.
        /// We can't have 2 methods with signature Main(string[]), but we can bind one explicitly to the interface.
        /// This means that whenever we're referring to our Program through an IConsoleThing reference, this is the method
        /// that'll get called. Honestly, as far as the workplace goes I think this is a terrible language feature and its
        /// only use is to cover up for bad design decisions. For this example, I'm using it to (hopefully) minimise your
        /// code changes to get this implementation going.
        /// </remarks>
        void IConsoleThing.Main(string[] args)
        {
            Console.WriteLine("Original flavour");
        }
    }
}
