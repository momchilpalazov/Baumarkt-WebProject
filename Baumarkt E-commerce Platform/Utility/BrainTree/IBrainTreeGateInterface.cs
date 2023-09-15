using Braintree;

namespace Baumarkt_E_commerce_Platform.Utility.BrainTree
{
    public interface IBrainTreeGateInterface
    {

          IBraintreeGateway  CreateGeteway();

          IBraintreeGateway GetGateway();

       



    }
}
