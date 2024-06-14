namespace GildedRose
{
    public static class ItemNames
    {
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        public const string AgedBrie = "Aged Brie";
        public const string BackstagePass = "Backstage passes to a TAFKAL80ETC concert";
        public const string Conjured = "Conjured";
    }

    public class GildedRose(List<Item> items)
    {
        private const int MaxQuality = 50;
        private const int MinimumQuality = 0;
        private const int SellInDoubleIncreaseThreshold = 11;
        private const int SellInTripleIncreaseThreshold = 6;

        readonly List<Item> Items = items;

        public void UpdateQuality()
        {
            Items.ForEach(UpdateItemQuality);
        }

        private void UpdateItemQuality(Item item)
        {
            switch (item.Name)
            {
                case ItemNames.Sulfuras:
                    // Quality never changes
                    break;
                case ItemNames.AgedBrie:
                    UpdateItem(item, HandleAgedBrieQuality);
                    break;
                case ItemNames.BackstagePass:
                    UpdateItem(item, HandleBackstagePassQuality);
                    break;
                case ItemNames.Conjured:
                    UpdateItem(item, HandleConjuredItemQuality);
                    break;
                default:
                    UpdateItem(item, HandleNormalItemQuality);
                    break;
            }
        }

        private static void UpdateItem(Item item, Action<Item> handleQuality)
        {
            DecreaseSellIn(item);
            handleQuality(item);
        }

        private static void HandleAgedBrieQuality(Item item)
        {
            IncreaseQuality(item);
            if (IsSellInDatePassed(item))
            {
                IncreaseQuality(item);
            }

            AllowUpToMaxQuality(item);
        }

        private static void HandleBackstagePassQuality(Item item)
        {
            IncreaseQuality(item);
            if (IsConcertSoon(item))
            {
                IncreaseQuality(item);
            }
            if (IsConcertWithinTheNextWeek(item))
            {
                IncreaseQuality(item);
            }

            if (IsSellInDatePassed(item))
            {
                SetMinimumQuality(item);
            }

            AllowUpToMaxQuality(item);
        }

        private static void HandleConjuredItemQuality(Item item)
        {
            if (CanDecreaseQuality(item))
            {
                DecreaseQuality(item, 2);
            }
            if (IsSellInDatePassed(item) && CanDecreaseQuality(item))
            {
                DecreaseQuality(item, 2);
            }
        }

        private static void HandleNormalItemQuality(Item item)
        {
            if (CanDecreaseQuality(item))
            {
                DecreaseQuality(item);
            }
            if (IsSellInDatePassed(item) && CanDecreaseQuality(item))
            {
                DecreaseQuality(item);
            }
        }

        private static void DecreaseSellIn(Item item)
        {
            item.SellIn--;
        }

        private static void IncreaseQuality(Item item)
        {
            item.Quality++;
        }

        private static void DecreaseQuality(Item item, int amount = 1)
        {
            item.Quality -= amount;
        }

        private static void SetMinimumQuality(Item item)
        {
            item.Quality = MinimumQuality;
        }

        private static void AllowUpToMaxQuality(Item item)
        {
            if (item.Quality > MaxQuality)
            {
                item.Quality = MaxQuality;
            }
        }

        private static bool CanDecreaseQuality(Item item)
        {
            return item.Quality > MinimumQuality;
        }

        private static bool IsConcertWithinTheNextWeek(Item item)
        {
            return item.SellIn < SellInTripleIncreaseThreshold;
        }

        private static bool IsConcertSoon(Item item)
        {
            return item.SellIn < SellInDoubleIncreaseThreshold;
        }

        private static bool IsSellInDatePassed(Item item)
        {
            return item.SellIn < 0;
        }
    }
}
