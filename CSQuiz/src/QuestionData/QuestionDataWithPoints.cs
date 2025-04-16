namespace Quiz
{
    public class QuestionDataWithPoints : QuestionData
    {
        public int Points { get; set; }

        public new void Validate()
        {
            base.Validate();

            if (Points <= 0)
            {
                throw new ArgumentException("Points must be greater than 0.");
            }
        }
    }
}