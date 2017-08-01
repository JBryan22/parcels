using System.Collections.Generic;

namespace Parcel.Models
{
  public class ParcelObject
  {
    private int _height;
    private int _width;
    private int _length;
    private int _weight;
    private static List<ParcelObject> _Parcels = new List<ParcelObject> {};

    public ParcelObject(int inputHeight, int inputWidth, int inputLength, int inputWeight)
    {
      _height = inputHeight;
      _width = inputWidth;
      _length = inputLength;
      _weight = inputWeight;
    }

    public ParcelObject()
    {

    }

    public int GetHeight()
    {
      return _height;
    }

    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }

    public int GetWidth()
    {
      return _width;
    }

    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public int GetLength()
    {
      return _length;
    }

    public void SetLength(int newLength)
    {
      _length = newLength;
    }

    public int GetVolume()
    {
      return _length * _width * _height;
    }

    public int CostToShip()
    {
      return (GetVolume() + (_weight * 3)) / 2;
    }

    public void Save()
    {
      _Parcels.Add(this);
    }

    public static List<ParcelObject> GetAll()
    {
      return _Parcels;
    }
  }
}
