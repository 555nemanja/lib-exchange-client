/* 
 * Blockchain.com Exchange REST API
 *
 * ## Introduction Welcome to Blockchain.com's Exchange API and developer documentation. \\ These documents detail and give examples of various functionality offered by the API such as receiving real time market data, requesting balance information and performing trades. ## To Get Started Create or log into your existing Blockchain.com Exchange account \\ Select API from the drop down menu \\ Fill out form and click “Create New API Key Now” \\ Once generated you can view your keys under API Settings. \\ Please be aware that the API key can only be used once it was verified via email.  The API key must be set via the \\ `X-API-Token`\\ header.  The base URL to be used for all calls is \\ `https://api.blockchain.com/v3/exchange`  Autogenerated clients for this API can be found [here](https://github.com/blockchain/lib-exchange-client). 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.com.blockchain.exchange.rest.model
{
    /// <summary>
    /// OrderBook
    /// </summary>
    [DataContract]
    public partial class OrderBook :  IEquatable<OrderBook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBook" /> class.
        /// </summary>
        /// <param name="symbol">Blockchain symbol identifier.</param>
        /// <param name="bids">bids.</param>
        /// <param name="asks">asks.</param>
        public OrderBook(string symbol = default(string), List<OrderBookEntry> bids = default(List<OrderBookEntry>), List<OrderBookEntry> asks = default(List<OrderBookEntry>))
        {
            this.Symbol = symbol;
            this.Bids = bids;
            this.Asks = asks;
        }
        
        /// <summary>
        /// Blockchain symbol identifier
        /// </summary>
        /// <value>Blockchain symbol identifier</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Bids
        /// </summary>
        [DataMember(Name="bids", EmitDefaultValue=false)]
        public List<OrderBookEntry> Bids { get; set; }

        /// <summary>
        /// Gets or Sets Asks
        /// </summary>
        [DataMember(Name="asks", EmitDefaultValue=false)]
        public List<OrderBookEntry> Asks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderBook {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Bids: ").Append(Bids).Append("\n");
            sb.Append("  Asks: ").Append(Asks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderBook);
        }

        /// <summary>
        /// Returns true if OrderBook instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderBook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderBook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Bids == input.Bids ||
                    this.Bids != null &&
                    input.Bids != null &&
                    this.Bids.SequenceEqual(input.Bids)
                ) && 
                (
                    this.Asks == input.Asks ||
                    this.Asks != null &&
                    input.Asks != null &&
                    this.Asks.SequenceEqual(input.Asks)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.Bids != null)
                    hashCode = hashCode * 59 + this.Bids.GetHashCode();
                if (this.Asks != null)
                    hashCode = hashCode * 59 + this.Asks.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {

            
            // Symbol (string) pattern
            Regex regexSymbol = new Regex(@"^[A-Z]{3,5}-[A-Z]{3,5}$", RegexOptions.CultureInvariant);
            if (false == regexSymbol.Match(this.Symbol).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Symbol, must match a pattern of " + regexSymbol, new [] { "Symbol" });
            }

            yield break;
        }
    }

}
