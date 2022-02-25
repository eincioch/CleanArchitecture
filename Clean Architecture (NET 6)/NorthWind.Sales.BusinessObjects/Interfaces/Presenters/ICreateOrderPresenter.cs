

namespace NorthWind.Sales.BusinessObjects.Interfaces.Presenters;
public interface ICreateOrderPresenter : ICreateOrderOutputPort
{
  // xml / json / formateado (devolver datos) aaqui
  int OrderId { get; }
  //demo Content { get; }
}

//class demo {
//  public int OrderId { get; set; }
//  public bool Result { get; set; }
//}
