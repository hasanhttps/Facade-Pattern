using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Facade_Pattern_Homework.models;

public interface MobileShop {
    public void ModelNo();
    public void ModelName();
}

public class SamsunsgShop : MobileShop {
    public void ModelName() {
        MessageBox.Show("Samsung a");
    }

    public void ModelNo() {
        MessageBox.Show("a7");
    }
}

public class IphoneShop : MobileShop {
    public void ModelName() {
        MessageBox.Show("Iphone");
    }

    public void ModelNo() {
        MessageBox.Show("14");
    }
}

public class XiaomiShop : MobileShop {
    public void ModelName() {
        MessageBox.Show("Xiaomi s");
    }

    public void ModelNo() {
        MessageBox.Show("s9");
    }
}

public class Shop {

    public IphoneShop? IphoneShop { get; set;}
    public SamsunsgShop? SamsunsgShop { get; set;}
    public XiaomiShop? XiaomiShop { get; set;}

    public Shop() {
        IphoneShop = new IphoneShop();
        SamsunsgShop = new SamsunsgShop();
        XiaomiShop = new XiaomiShop();
    }

    public void IphoneSale() {
        IphoneShop!.ModelNo();
        IphoneShop.ModelName();
    }

    public void SamsungSale() { 
        SamsunsgShop!.ModelNo();
        SamsunsgShop.ModelName();
    }

    public void XiaomiSale() {
        XiaomiShop!.ModelNo();
        XiaomiShop.ModelName();
    }
}

public class Main {

    public void main() {
        Shop shop = new();
        shop.IphoneSale();
        shop.SamsungSale();
        shop.XiaomiSale();
    }
}