public class De extends GiaSuc {
    De() {
        super();
    }

    @Override
    public String getType() {
        return "Goat";
    }

    @Override
    public float TinhLuongSua() {
        if (Tuoi >= 1 && Tuoi <= 2) {
            return CanNang / 10;
        } else if (Tuoi <= 4) {
            return CanNang / 15;
        }
        return 0;
    }
}
