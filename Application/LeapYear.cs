public class LeapYear {
    public bool IsLeapYear(int year) {

        return IsDivBy4(year) && !IsDivBy100(year) || IsDivBy400(year);
    }

    public bool IsDivBy4(int num) {
        return num % 4 == 0;
    }

    public bool IsDivBy100(int num) {
        return false;
    }

    public bool IsDivBy400(int num) {
        return false;
    }
}