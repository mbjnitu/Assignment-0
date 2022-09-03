public class Program {

static void Main(string[] args) {

    var arg = Console.ReadLine();
    var ly = new LeapYear();

    var res = ly.IsLeapYear(int.Parse(arg));
    var response = res == true ? "yay" : "nay";
    Console.WriteLine(response);
}
public class HelloWorld {
    public String run() {
        return "Hello, World!";
    }
}
}
