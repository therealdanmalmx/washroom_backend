using Core.Models;

namespace API.Repositories;

public class PropertyAdministrationRepository : IPropertyAdministrationRepository
{
    private List<PropertyAdministration> _propertyAdministrations =
    [
        new PropertyAdministration
        {
            Id = Guid.NewGuid(),
            Name = "HSB",
            Logo = "https://www.hsb.se/contentassets/2ba369972d73485598f9c965076774cc/logo_apsis.jpg",
            CreatedAt = DateTime.Now,
        },
        new PropertyAdministration
        {
            Id = Guid.NewGuid(),
            Name = "Riksbyggen",
            Logo =
                "https://mnd-assets.mynewsdesk.com/image/upload/c_fill,dpr_auto,f_auto,g_xy_center,q_auto:good,w_1782,x_299,y_207/0wwly1zv6uf8oro3hq4sj6",
            CreatedAt = DateTime.Now,
        },
    ];
    public List<PropertyAdministration> GetAllPropertyAdministrations()
    {
        return _propertyAdministrations;
    }

    public List<PropertyAdministration> GetPropertyAdministration(Guid id)
    {
        throw new NotImplementedException();
        // return _propertyAdministrations.SingleOrDefault(p => p.Id == id);
    
    }

    public List<PropertyAdministration> CreatePropertyAdministration(PropertyAdministration newPropertyAdministration)
    {
        _propertyAdministrations.Add(newPropertyAdministration);
        return _propertyAdministrations;
    }
}