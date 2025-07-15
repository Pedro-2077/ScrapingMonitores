using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KabomMonitores
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Banners
    {
        public Main main { get; set; }
        public Sidebar sidebar { get; set; }
    }

    public class Breadcrumb
    {
        public int id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
    }

    public class BreadcrumbServer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
    }

    public class CatalogServer
    {
        public Meta meta { get; set; }
        public Links links { get; set; }
        public List<Datum> data { get; set; }
        public Pagination pagination { get; set; }
        public string redirect { get; set; }
    }

    public class Categories
    {
        public List<List> list { get; set; }
        public string basePath { get; set; }
        public string relatedCategory { get; set; }
        public List<Seo> seo { get; set; }
        public List<Faq> faq { get; set; }
    }

    public class Colors
    {
        public string main { get; set; }
        public string text { get; set; }
    }

    public class Datum
    {
        public int code { get; set; }
        public int productSpecie { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string tagDescription { get; set; }
        public int weight { get; set; }
        public string friendlyName { get; set; }
        public string sellerName { get; set; }
        public int sellerId { get; set; }
        public int offerIdMarketplace { get; set; }
        public string category { get; set; }
        public string externalUrl { get; set; }
        public Manufacturer manufacturer { get; set; }
        public string iframeUrl { get; set; }
        public string image { get; set; }
        public List<string> images { get; set; }
        public double price { get; set; }
        public double primePrice { get; set; }
        public double primePriceWithDiscount { get; set; }
        public int discountPercentagePrime { get; set; }
        public double oldPrice { get; set; }
        public double oldPrimePrice { get; set; }
        public string maxInstallment { get; set; }
        public double priceWithDiscount { get; set; }
        public double priceMarketplace { get; set; }
        public int discountPercentage { get; set; }
        public int offerDiscount { get; set; }
        public int quantity { get; set; }
        public int rating { get; set; }
        public int ratingCount { get; set; }
        public bool available { get; set; }
        public int preOrderDate { get; set; }
        public string warranty { get; set; }
        public object dateProductArrived { get; set; }
        public object html { get; set; }
        public List<object> ufsFlash { get; set; }
        public Stamps stamps { get; set; }
        public Flags flags { get; set; }
        public Origin origin { get; set; }
        public Prime prime { get; set; }
        public Offer offer { get; set; }
        public Colors colors { get; set; }
        public object paymentMethodsDefault { get; set; }
        public object paymentMethodsPrime { get; set; }
        public int tagCode { get; set; }
        public Photos photos { get; set; }
        public string thumbnail { get; set; }
        public object promotionBanner { get; set; }
        public object campaignBanners { get; set; }
        public List<object> crossCart { get; set; }
        public bool crossSelling { get; set; }
    }

    public class Faq
    {
        public string question { get; set; }
        public string answer { get; set; }
    }

    public class Filter
    {
        public string name { get; set; }
        public List<object> values { get; set; }
        public string text { get; set; }
        public int? min { get; set; }
        public int? max { get; set; }
    }

    public class Flags
    {
        public bool isMarketplace { get; set; }
        public bool isOpenbox { get; set; }
        public bool isFreeShipping { get; set; }
        public bool isFreeShippingPrime { get; set; }
        public bool isPixShipping { get; set; }
        public bool isPreOrder { get; set; }
        public bool isFlash { get; set; }
        public bool isPrime { get; set; }
        public bool isOffer { get; set; }
        public bool hasGift { get; set; }
        public bool isHighlight { get; set; }
    }

    public class Links
    {
        public string redirect { get; set; }
        public string first { get; set; }
        public string self { get; set; }
        public string last { get; set; }
        public string next { get; set; }
    }

    public class List
    {
        public int code { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public int count_children { get; set; }
    }

    public class Main
    {
        public string titulo { get; set; }
        public string subtitulo { get; set; }
        public string link { get; set; }
        public string banner { get; set; }
        public string banner_mobile { get; set; }
        public string background { get; set; }
        public bool target_blank { get; set; }
        public string banner_id { get; set; }
        public string creative { get; set; }
    }

    public class Manufacturer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
    }

    public class Meta
    {
        public List<Breadcrumb> breadcrumb { get; set; }
        public Seo seo { get; set; }
        public Promotion promotion { get; set; }
        public int totalItemsCount { get; set; }
        public int totalPagesCount { get; set; }
        public Page page { get; set; }
        public List<Filter> filters { get; set; }
    }

    public class Offer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string referenceBanner { get; set; }
        public int endsAt { get; set; }
        public int startsAt { get; set; }
        public object isPrimeExclusive { get; set; }
        public double price { get; set; }
        public double priceWithDiscount { get; set; }
        public int discountPercentage { get; set; }
        public int quantityAvailable { get; set; }
        public string hashCode { get; set; }
    }

    public class Origin
    {
        public object id { get; set; }
        public object name { get; set; }
    }

    public class Page
    {
        public string cursor { get; set; }
        public int number { get; set; }
        public int size { get; set; }
        public bool isCurrentPage { get; set; }
    }

    public class Pagination
    {
        public int prev { get; set; }
        public int current { get; set; }
        public int next { get; set; }
        public int total { get; set; }
    }

    public class Params
    {
        public int page_number { get; set; }
        public int page_size { get; set; }
        public string facet_filters { get; set; }
        public string sort { get; set; }
        public bool is_prime { get; set; }
        public string payload_data { get; set; }
    }

    public class Photos
    {
        public List<string> p { get; set; }
        public List<string> m { get; set; }
        public List<string> g { get; set; }
        public List<string> gg { get; set; }
    }

    public class Prime
    {
        public double price { get; set; }
        public double priceWithDiscount { get; set; }
        public int discountPercentage { get; set; }
        public int save { get; set; }
        public string maxInstallmentPrime { get; set; }
    }

    public class Promotion
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class KabumObject
    {
        public CatalogServer catalogServer { get; set; }
        public List<BreadcrumbServer> breadcrumbServer { get; set; }
        public Seo seo { get; set; }
        public Banners banners { get; set; }
        public Categories categories { get; set; }
        public string slug { get; set; }
        public Params @params { get; set; }
        public string type { get; set; }
        public string pagelist { get; set; }
        public bool cookieIsMobile { get; set; }
    }

    public class Seo
    {
        public string title { get; set; }
        public string description { get; set; }
        public string titleHeading { get; set; }
        public int active { get; set; }
        public int code { get; set; }
        public string content { get; set; }
        public int position { get; set; }
    }

    public class Sidebar
    {
    }

    public class Stamps
    {
        public int id { get; set; }
        public string title { get; set; }
        public string name { get; set; }
        public string backgroundColor { get; set; }
        public string fontColor { get; set; }
        public string type { get; set; }
    }




}
