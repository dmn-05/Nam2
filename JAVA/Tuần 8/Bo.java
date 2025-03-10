public class Bo extends GiaSuc {
    Bo() {
        super();
    }

    @Override
    public String getType() {
        return "Cow";
    }

    @Override
    public float TinhLuongSua() {
        if (Tuoi >= 2 && Tuoi <= 5) {
            return (Math.max(0, (CanNang - Tuoi) / 10));
        }
        return 0;
    }
}
