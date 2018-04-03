using System;
using Expecto;
using Expecto.CSharp;

namespace YoloDevMCVE
{
    public class Program
    {
        [Tests]
        public static Test TestList =
            Runner.TestList("A simple test 2", new Test[] {
                Runner.TestCase("SimpleTest",
                        () => Expect.equal("Hello World", "Hello World", "The strings should equal"))
            });
    }
}

