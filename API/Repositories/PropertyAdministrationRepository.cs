using Core.Models;

namespace API.Repositories;

public class PropertyAdministrationRepository : IPropertyAdministrationRepository
{
    private List<PropertyAdministration> _propertyAdministrations =
    [
        new PropertyAdministration
        {
            Id = 1,
            Name = "HSB",
            Logo = "https://www.hsb.se/contentassets/2ba369972d73485598f9c965076774cc/logo_apsis.jpg",
        },
        new PropertyAdministration
        {
            Id = 2,
            Name = "Riksbyggen",
            Logo =
                "https://mnd-assets.mynewsdesk.com/image/upload/c_fill,dpr_auto,f_auto,g_xy_center,q_auto:good,w_1782,x_299,y_207/0wwly1zv6uf8oro3hq4sj6",
        },
    ];
    public List<PropertyAdministration> GetAllPropertyAdministrations()
    {
        return _propertyAdministrations;
    }

    public PropertyAdministration GetPropertyAdministration(int id)
    {
        var singlePropertyAdministration =  _propertyAdministrations.FirstOrDefault(p => p.Id == id);
        if (singlePropertyAdministration == null)
        {
            return null;
        }

        return singlePropertyAdministration;
    }

    public List<PropertyAdministration> CreatePropertyAdministration(PropertyAdministration newPropertyAdministration)
    {
        _propertyAdministrations.Add(newPropertyAdministration);
        return _propertyAdministrations;
    }

    public List<PropertyAdministration>? UpdatePropertyAdministration(int id, PropertyAdministration updatePropertyAdministration)
    {
        var propertyAdministrationToUpdateIndex = _propertyAdministrations.FindIndex(pa => pa.Id == id);
        if (propertyAdministrationToUpdateIndex == -1)
        {
            return null;
        }
        _propertyAdministrations[propertyAdministrationToUpdateIndex] = updatePropertyAdministration;
        return _propertyAdministrations;
    }

    public List<PropertyAdministration>? DeletePropertyAdministration(int id)
    {
        var propertyAdministrationToDelete = _propertyAdministrations.FirstOrDefault(pa => pa.Id == id);
        if (propertyAdministrationToDelete == null)
        {
            return null;
        }
        _propertyAdministrations.Remove(propertyAdministrationToDelete);
        return _propertyAdministrations;
    }
}