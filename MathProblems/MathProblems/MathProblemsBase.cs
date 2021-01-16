using System.IO;

namespace MathProblems
{
    public class MathProblemsBase : IMathProblems
    {
        protected int SheetCount = 9;
        protected int SampleCount = 20;
        protected readonly string _MissingNumberOneDigit = "";
        protected readonly string _OneDigitOperation = "";
        protected readonly string _OneDigitAndTwoDigitOperation = "";
        protected readonly string _TwoDigitOperation = "";
        protected const string OneDigitSeprator = "__";
        protected const string TwoDigitSeprator = "____";
        protected const string EqualTo = " = ";
        protected const string basePath = @"C:\temp";
        private string @operator;

        public MathProblemsBase(string className)
        {
            var addtionBasePath = Path.Combine(basePath, nameof(Addition));
            if (!Directory.Exists(addtionBasePath))
            {
                Directory.CreateDirectory(addtionBasePath);
            }

            _MissingNumberOneDigit = Path.Combine(addtionBasePath, nameof(MissingNumberOneDigit));
            if (!Directory.Exists(_MissingNumberOneDigit))
            {
                Directory.CreateDirectory(_MissingNumberOneDigit);
            }
            _OneDigitOperation = Path.Combine(addtionBasePath, nameof(OneDigitOperation));
            if (!Directory.Exists(_OneDigitOperation))
            {
                Directory.CreateDirectory(_OneDigitOperation);
            }
            _OneDigitAndTwoDigitOperation = Path.Combine(addtionBasePath, nameof(OneDigitAndTwoDigitOperation));
            if (!Directory.Exists(_OneDigitAndTwoDigitOperation))
            {
                Directory.CreateDirectory(_OneDigitAndTwoDigitOperation);
            }
            _TwoDigitOperation = Path.Combine(addtionBasePath, nameof(TwoDigitiOperation));
            if (!Directory.Exists(_TwoDigitOperation))
            {
                Directory.CreateDirectory(_TwoDigitOperation);
            }

        }
        public virtual string GetOperator()
        {
            return @operator;
        }

        public virtual void TwoDigitiOperation() { }
        public virtual void OneDigitAndTwoDigitOperation() { }
        public virtual void MissingNumberOneDigit()
        {

        }
        public virtual void OneDigitOperation() { }
        public virtual void CreateDirectory()
        {

        }
    }
}