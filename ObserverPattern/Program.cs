// Allow for subscription to a source, so everyone is notified when a change occurs

using ObserverPattern;

Market market = new Market();

MobileMarket mobileEast = new MobileMarket("mobileEast");

WebMarket webSouth = new WebMarket("webSouth");
WebMarket webNorth = new WebMarket("webNorth");

market.Attach(mobileEast);
market.Attach(webSouth);
market.Attach(webNorth);

market.SetPrice(12.5);

market.Detach(mobileEast);

market.SetPrice(13.2);