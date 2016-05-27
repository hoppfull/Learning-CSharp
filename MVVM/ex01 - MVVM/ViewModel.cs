namespace ex01 {
    class ViewModel {
        private Model Model { get; }
        public string Greeting { get; }
        public int MeaningOfLife { get; }
        public ViewModel() {
            Model = new Model {
                Message = "Hello MVVM",
                Count = 42
            };
            Greeting = Model.Message;
            MeaningOfLife = Model.Count;
        }
    }
}
