using Microsoft.ML.Data;

namespace DeepLearning_ImageClassification_Binary
{
    public class ImageData
    {
        [LoadColumn(0)]
        public string ImagePath;

        [LoadColumn(1)]
        public string Label;
    }
}
