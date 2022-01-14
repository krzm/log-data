#nullable enable
using Core;
using Core.Lib;

namespace Log.Data;

public class PlaceUpdate : ModelAUpdate, IUpdatable<Place>
{
    public void Update(Place model)
    {
        base.Update(model);
    }
}