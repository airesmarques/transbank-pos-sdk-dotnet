//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Transbank.POS.Utils {

public class TransbankWrap {
  public static string list_ports() {
    string ret = TransbankWrapPINVOKE.list_ports();
    return ret;
  }

  public static string get_port_name(SWIGTYPE_p_sp_port port) {
    string ret = TransbankWrapPINVOKE.get_port_name(SWIGTYPE_p_sp_port.getCPtr(port));
    return ret;
  }

  public static int read_bytes(SWIGTYPE_p_sp_port port, string buf, SWIGTYPE_p_Message message) {
    int ret = TransbankWrapPINVOKE.read_bytes(SWIGTYPE_p_sp_port.getCPtr(port), buf, SWIGTYPE_p_Message.getCPtr(message));
    if (TransbankWrapPINVOKE.SWIGPendingException.Pending) throw TransbankWrapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int read_ack(SWIGTYPE_p_sp_port port) {
    int ret = TransbankWrapPINVOKE.read_ack(SWIGTYPE_p_sp_port.getCPtr(port));
    return ret;
  }

  public static byte calculate_lrc(string message, int length) {
    byte ret = TransbankWrapPINVOKE.calculate_lrc(message, length);
    return ret;
  }

  public static int reply_ack(SWIGTYPE_p_sp_port port, string message, int length) {
    int ret = TransbankWrapPINVOKE.reply_ack(SWIGTYPE_p_sp_port.getCPtr(port), message, length);
    return ret;
  }

  public static int write_message(SWIGTYPE_p_sp_port port, SWIGTYPE_p_Message message) {
    int ret = TransbankWrapPINVOKE.write_message(SWIGTYPE_p_sp_port.getCPtr(port), SWIGTYPE_p_Message.getCPtr(message));
    if (TransbankWrapPINVOKE.SWIGPendingException.Pending) throw TransbankWrapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static TbkReturn open_port(string portName, int baudrate) {
    TbkReturn ret = (TbkReturn)TransbankWrapPINVOKE.open_port(portName, baudrate);
    return ret;
  }

  public static string sale(int amount, int ticket, bool send_messages) {
    string ret = TransbankWrapPINVOKE.sale(amount, ticket, send_messages);
    return ret;
  }

  public static string last_sale() {
    string ret = TransbankWrapPINVOKE.last_sale();
    return ret;
  }

  public static BaseResponse close() {
    BaseResponse ret = new BaseResponse(TransbankWrapPINVOKE.close(), true);
    return ret;
  }

  public static BaseResponse load_keys() {
    BaseResponse ret = new BaseResponse(TransbankWrapPINVOKE.load_keys(), true);
    return ret;
  }

  public static TotalsResponse get_totals() {
    TotalsResponse ret = new TotalsResponse(TransbankWrapPINVOKE.get_totals(), true);
    return ret;
  }

  public static TbkReturn poll() {
    TbkReturn ret = (TbkReturn)TransbankWrapPINVOKE.poll();
    return ret;
  }

  public static TbkReturn set_normal_mode() {
    TbkReturn ret = (TbkReturn)TransbankWrapPINVOKE.set_normal_mode();
    return ret;
  }

  public static TbkReturn close_port() {
    TbkReturn ret = (TbkReturn)TransbankWrapPINVOKE.close_port();
    return ret;
  }

}

}
