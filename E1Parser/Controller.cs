namespace E1Parser {
    public interface Controller {
        void StartWork();
        void Activate();
        void BindWithModel(Model model);
        void BindWithView(View view);
    }
}
