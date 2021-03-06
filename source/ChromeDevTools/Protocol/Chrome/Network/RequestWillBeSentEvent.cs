using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when page is about to send HTTP request.
	/// </summary>
	[Event(ProtocolName.Network.RequestWillBeSent)]
	[SupportedBy("Chrome")]
	public class RequestWillBeSentEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Frame identifier.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Loader identifier.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets URL of the document this request is loaded for.
		/// </summary>
		public string DocumentURL { get; set; }
		/// <summary>
		/// Gets or sets Request data.
		/// </summary>
		public Request Request { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets UTC Timestamp.
		/// </summary>
		public double WallTime { get; set; }
		/// <summary>
		/// Gets or sets Request initiator.
		/// </summary>
		public Initiator Initiator { get; set; }
		/// <summary>
		/// Gets or sets Redirect response data.
		/// </summary>
		public Response RedirectResponse { get; set; }
		/// <summary>
		/// Gets or sets Type of this resource.
		/// </summary>
		public Page.ResourceType Type { get; set; }
	}
}
