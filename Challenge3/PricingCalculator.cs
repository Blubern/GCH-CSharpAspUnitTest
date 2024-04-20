namespace BlazorAppGithubCopilot
{
    public class PricingCalculator
    {
        private const decimal defaultTaxRate = 0.19m;

        public decimal CalculateTotalPrice(decimal basePrice, int quantity, string customerType, int currentMonth, bool specialPromotionActive, decimal taxRate = defaultTaxRate)
        {
            decimal totalPrice = basePrice * quantity;

            if (quantity >= 10 && quantity < 20)
            {
                totalPrice *= 0.95m;
            }
            else if (quantity >= 20)
            {
                totalPrice *= 0.90m;
            }

            switch (customerType.ToLower())
            {
                case "vip":
                    totalPrice *= 0.85m;
                    break;
                case "wholesale":
                    totalPrice *= 0.80m;
                    break;
                case "retail":
                    break;
                default:
                    throw new ArgumentException("Invalid customer type.");
            }

            if (currentMonth == 12 || currentMonth == 1 || currentMonth == 2)
            {
                totalPrice *= 0.95m;
            }
            else if (currentMonth == 7 || currentMonth == 8)
            {
                totalPrice *= 1.05m;
            }

            if (specialPromotionActive)
            {
                totalPrice *= 0.90m;
            }

            totalPrice *= (1 + taxRate);

            return totalPrice;
        }
    }

    public bool IsValid(string value)
    {
        string pattern = "^(?:(?:31(\\/|-|\\.)(?:0?[13578]|1[02]|(?:Jan|jan|JAN|Mar|mar|MAR|May|may|MAY|Jul|jul|JUL|Aug|aug|AUG|Oct|oct|OCT|Dec|dec|DEC)))\\1|(?:(?:29|30)(\\/|-|\\.)(?:0?[1,3-9]|1[0-2]|(?:Jan|jan|JAN|Mar|mar|MAR|Apr|apr|APR|May|may|MAY|Jun|jun|JUN|Jul|jul|JUL|Aug|aug|AUG|Sep|sep|SEP|Oct|oct|OCT|Nov|nov|NOV|Dec|dec|DEC))\\2))(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$|^(?:29(\\/|-|\\.)(?:0?2|(?:Feb|feb|FEB))\\3(?:(?:(?:1[6-9]|[2-9]\\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\\d|2[0-8])(\\/|-|\\.)(?:(?:0?[1-9]|(?:Jan|jan|JAN|Feb|feb|FEB|Mar|mar|MAR|Apr|apr|APR|May|may|MAY|Jun|jun|JUN|Jul|jul|JUL|Aug|aug|AUG|Sep|sep|SEP))|(?:1[0-2]|(?:Oct|oct|OCT|Nov|nov|NOV|Dec|dec|DEC)))\\4(?:(?:1[6-9]|[2-9]\\d)?\\d{2})$\r\n";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(value);
    }
}
