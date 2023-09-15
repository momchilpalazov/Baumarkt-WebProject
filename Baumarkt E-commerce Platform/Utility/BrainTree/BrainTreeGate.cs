using Braintree;
using Microsoft.Extensions.Options;

namespace Baumarkt_E_commerce_Platform.Utility.BrainTree
{
    public class BrainTreeGate : IBrainTreeGateInterface
    {

        public BrainTreePropertySettings _brainOptions { get; set; }

        private IBraintreeGateway braintreeGateway;

        public BrainTreeGate( IOptions<BrainTreePropertySettings> brainOptions)
        {
            _brainOptions = brainOptions.Value;
           
        }   



        public IBraintreeGateway CreateGeteway()
        {
            return new BraintreeGateway(_brainOptions.Environment, _brainOptions.MerchantId, _brainOptions.PublicKey, _brainOptions.PrivateKey);
        }

        public IBraintreeGateway GetGateway()
        {
           if(braintreeGateway == null)
           {
               braintreeGateway = CreateGeteway();
           }

           return braintreeGateway;
        }
    }


}
