public class LeapYear {
    public bool IsLeapYear(string year) {
        try {
            var arg = int.Parse(year);
            return CalcIfLeapYear(arg);
        }
        catch (FormatException) {
            return false;
        }
    }

    public bool IsLeapYear(int year) {
        return CalcIfLeapYear(year);
    }

    private bool CalcIfLeapYear(int year) {
        if (year < 1582) return false;
        return IsDivBy4(year) && !IsDivBy100(year) || IsDivBy400(year);
    }

    public bool IsDivBy4(int num) {
        return num % 4 == 0;
    }

    public bool IsDivBy100(int num) {
        return num % 100 == 0;
    }

    public bool IsDivBy400(int num) {
        return num % 400 == 0;
    }
}