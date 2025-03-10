import java.util.LinkedList;

class NongTrai {
    private LinkedList<GiaSuc> nongTrai;

    NongTrai() {
        this.nongTrai = new LinkedList<>();
    }

    public void addCattle(GiaSuc cattle) {
        this.nongTrai.addLast(cattle);
    }

    public void showNongTrai() {
        for (GiaSuc cattle : nongTrai) {
            cattle.xuat();
        }
    }

    public double calculateSumOfMilkAmount() {
        double sumOfMilkAmount = 0;
        for (Cattle cattle : NongTrai) {
            sumOfMilkAmount += cattle.calculateMilkAmount();
        }
        return sumOfMilkAmount;
    }

    public double calculateSumOfCowMilkAmount() {
        double sumOfCowMilkAmount = 0;
        for (GiaSuc cattle : nongTrai) {
            if (cattle.getType() == "Cow") {
                sumOfCowMilkAmount += cattle.TinhLuongSua();
            }
        }
        return sumOfCowMilkAmount;
    }

    public double calculateSumOfGoatMilkAmount() {
        double sumOfGoatMilkAmount = 0;
        for (GiaSuc cattle : nongTrai) {
            if (cattle.getType() == "Goat") {
                sumOfGoatMilkAmount += cattle.TinhLuongSua();
            }
        }
        return sumOfGoatMilkAmount;
    }

    public double findMaxMilkAmount() {
        double maxMilkAmount = -1;
        for (GiaSuc cattle : nongTrai) {
            if (cattle.TinhLuongSua() > maxMilkAmount) {
                maxMilkAmount = cattle.TinhLuongSua();
            }
        }
        return maxMilkAmount;
    }

    public GiaSuc findCattleWhichHasMaxMilkAmount() {
        GiaSuc _cattle = NongTrai.get(0);
        for (GiaSuc cattle : nongTrai) {
            if (cattle.TinhLuongSua() > _cattle.TinhLuongSua()) {
                _cattle = cattle;
            }
        }
        return _cattle;
    }
}
