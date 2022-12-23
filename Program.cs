// See https://aka.ms/new-console-template for more information
using Vcard;

var myCard = new VCard
{
    FirstName = "Senthil Kumar",
    LastName = "G",
    Organization = "Kanini",
    JobTitle = "Title of Job",
    StreetAddress = "Tööstuse 48",
    City = "Tallinn",
    CountryName = "Estonia",
    Phone = "343-23232",
    Mobile = "232-67854",
    Email = "gunnar@secret-address.com",
    HomePage = "www.developers-team.com"
};
myCard.Image = File.ReadAllBytes("vcardphoto.png");
using (var file = File.OpenWrite("vcardphoto.vcf"))
using (var writer = new StreamWriter(file))
{
    writer.Write(myCard.ToString());
}


