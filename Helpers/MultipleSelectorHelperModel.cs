namespace GameIndustryModule2.Helpers
{
    // Урок 16 (3.2)
    // Меняем класс на структуру
    public struct MultipleSelectorHelperModel
    {
        public MultipleSelectorHelperModel(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }

        // Будем использовать эту модель для компонента MultipleSelector, идём в него
    }
}
