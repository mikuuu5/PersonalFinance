using System;
using System.Windows;
namespace PFM.DawnXZ.WPF.Codes
{
    //General commissioned a single parameter
    public class DelegateSingle
    {
        #region Delegate & Event
        //Declare a delegate
        /// <param name="sender">The delegate object</param>
        /// <param name="e">The delegate event</param>
        public delegate void UpdateInfoEventHandler(object sender, UpdateInfoEventArgs e);
        //Declare a delegate event
        private event UpdateInfoEventHandler UpdateInfo;
        #endregion Delegate & Event
        #region Delegate event class
        //Delegate event class
        public class UpdateInfoEventArgs : EventArgs
        {
            //To update the information
            public readonly string _strInfo;
            //Constructed function       
            /// <param name="strInfo">To update the information</param>
            public UpdateInfoEventArgs(string strInfo)
            {
                this._strInfo = strInfo;
            }
        }
        #endregion Delegate event class
        #region Register & UnRegister
        //To register more than one method for an event
        /// <param name="method">Method name</param>
        public void Register(UpdateInfoEventHandler method)
        {
            UpdateInfo += method;
        }
        // Registered with the event a unique method
        /// <param name="method">Method name</param>
        public void RegisterOnly(UpdateInfoEventHandler method)
        {
            UpdateInfo = method;
        }
        //Registered with the event against method
        /// <param name="method">Method name</param>
        public void UnRegister(UpdateInfoEventHandler method)
        {
            UpdateInfo -= method;
        }
        //Registered with the event against method
        public void UnRegister()
        {
            UpdateInfo = null;
        }
        #endregion Register & UnRegister
        #region Virtual
        // Can be overridden execute method
        /// <param name="wid">System.Windows.Window</param>
        /// <param name="e">The delegate event</param>
        protected virtual void OnUpdateInfo(Window wid, UpdateInfoEventArgs e)
        {
            if (UpdateInfo != null && wid != null) wid.Dispatcher.Invoke(UpdateInfo, this, e);
        }
        #endregion Virtual
        #region Member method
        //Executes a delegate method
        /// <param name="wid">System.Windows.Window</param>
        /// <param name="strInfo">To update the information</param>
        public void Executes(Window wid, string strInfo)
        {
            UpdateInfoEventArgs e = new UpdateInfoEventArgs(strInfo);
            OnUpdateInfo(wid, e);
            e = null;
        }
        #endregion Member method
    }
}
