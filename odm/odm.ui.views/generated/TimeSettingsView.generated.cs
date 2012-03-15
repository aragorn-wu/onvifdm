﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reactive.Disposables;
using System.Windows.Input;
using odm.infra;
namespace odm.ui.activities {
	
	public partial class TimeSettingsView{
		
		#region Model definition
		
		public interface IModelAccessor{
			DateTime utcDateTime{get;set;}
			bool useDateTimeFromNtp{get;set;}
			string timeZone{get;set;}
			bool daylightSavings{get;set;}
			
		}
		public class Model: IModelAccessor, INotifyPropertyChanged{
			
			public Model(
				long timestamp
			){
				
				this.timestamp = timestamp;
			}
			private Model(){
			}
			

			public static Model Create(
				long timestamp,
				DateTime utcDateTime,
				bool useDateTimeFromNtp,
				string timeZone,
				bool daylightSavings
			){
				var _this = new Model();
				
				_this.timestamp = timestamp;
				_this.origin.utcDateTime = utcDateTime;
				_this.origin.useDateTimeFromNtp = useDateTimeFromNtp;
				_this.origin.timeZone = timeZone;
				_this.origin.daylightSavings = daylightSavings;
				_this.RevertChanges();
				
				return _this;
			}
		
				private SimpleChangeTrackable<DateTime> m_utcDateTime;
				private SimpleChangeTrackable<bool> m_useDateTimeFromNtp;
				private SimpleChangeTrackable<string> m_timeZone;
				private SimpleChangeTrackable<bool> m_daylightSavings;
				public long timestamp{get;private set;}

			private class OriginAccessor: IModelAccessor {
				private Model m_model;
				public OriginAccessor(Model model) {
					m_model = model;
				}
				DateTime IModelAccessor.utcDateTime {
					get {return m_model.m_utcDateTime.origin;}
					set {m_model.m_utcDateTime.origin = value;}
				}
				bool IModelAccessor.useDateTimeFromNtp {
					get {return m_model.m_useDateTimeFromNtp.origin;}
					set {m_model.m_useDateTimeFromNtp.origin = value;}
				}
				string IModelAccessor.timeZone {
					get {return m_model.m_timeZone.origin;}
					set {m_model.m_timeZone.origin = value;}
				}
				bool IModelAccessor.daylightSavings {
					get {return m_model.m_daylightSavings.origin;}
					set {m_model.m_daylightSavings.origin = value;}
				}
				
			}
			public event PropertyChangedEventHandler PropertyChanged;
			private void NotifyPropertyChanged(string propertyName){
				var prop_changed = this.PropertyChanged;
				if (prop_changed != null) {
					prop_changed(this, new PropertyChangedEventArgs(propertyName));
				}
			}
			
			public DateTime utcDateTime  {
				get {return m_utcDateTime.current;}
				set {
					if(m_utcDateTime.current != value) {
						m_utcDateTime.current = value;
						NotifyPropertyChanged("utcDateTime");
					}
				}
			}
			
			public bool useDateTimeFromNtp  {
				get {return m_useDateTimeFromNtp.current;}
				set {
					if(m_useDateTimeFromNtp.current != value) {
						m_useDateTimeFromNtp.current = value;
						NotifyPropertyChanged("useDateTimeFromNtp");
					}
				}
			}
			
			public string timeZone  {
				get {return m_timeZone.current;}
				set {
					if(m_timeZone.current != value) {
						m_timeZone.current = value;
						NotifyPropertyChanged("timeZone");
					}
				}
			}
			
			public bool daylightSavings  {
				get {return m_daylightSavings.current;}
				set {
					if(m_daylightSavings.current != value) {
						m_daylightSavings.current = value;
						NotifyPropertyChanged("daylightSavings");
					}
				}
			}
			
			public void AcceptChanges() {
				m_utcDateTime.AcceptChanges();
				m_useDateTimeFromNtp.AcceptChanges();
				m_timeZone.AcceptChanges();
				m_daylightSavings.AcceptChanges();
				
			}

			public void RevertChanges() {
				this.current.utcDateTime= this.origin.utcDateTime;
				this.current.useDateTimeFromNtp= this.origin.useDateTimeFromNtp;
				this.current.timeZone= this.origin.timeZone;
				this.current.daylightSavings= this.origin.daylightSavings;
				
			}

			public bool isModified {
				get {
					if(m_utcDateTime.isModified)return true;
					if(m_useDateTimeFromNtp.isModified)return true;
					if(m_timeZone.isModified)return true;
					if(m_daylightSavings.isModified)return true;
					
					return false;
				}
			}

			public IModelAccessor current {
				get {return this;}
				
			}

			public IModelAccessor origin {
				get {return new OriginAccessor(this);}
				
			}
		}
			
		#endregion
	
		#region Result definition
		public abstract class Result{
			private Result() { }
			
			public abstract T Handle<T>(
				
				Func<Model,T> apply,
				Func<T> close
			);
	
			public bool IsApply(){
				return AsApply() != null;
			}
			public virtual Apply AsApply(){ return null; }
			public class Apply : Result {
				public Apply(Model model){
					
					this.model = model;
					
				}
				public Model model{ get; set; }
				public override Apply AsApply(){ return this; }
				
				public override T Handle<T>(
				
					Func<Model,T> apply,
					Func<T> close
				){
					return apply(
						model
					);
				}
	
			}
			
			public bool IsClose(){
				return AsClose() != null;
			}
			public virtual Close AsClose(){ return null; }
			public class Close : Result {
				public Close(){
					
				}
				
				public override Close AsClose(){ return this; }
				
				public override T Handle<T>(
				
					Func<Model,T> apply,
					Func<T> close
				){
					return close(
						
					);
				}
	
			}
			
		}
		#endregion

		public ICommand ApplyCommand{ get; private set; }
		public ICommand CloseCommand{ get; private set; }
		
		IActivityContext<Result> activityContext = null;
		SingleAssignmentDisposable activityCancellationSubscription = new SingleAssignmentDisposable();
		bool activityCompleted = false;
		//activity has been completed
		event Action OnCompleted = null;
		//activity has been failed
		event Action<Exception> OnError = null;
		//activity has been completed successfully
		event Action<Result> OnSuccess = null;
		//activity has been canceled
		event Action OnCancelled = null;
		
		public TimeSettingsView(Model model, IActivityContext<Result> activityContext) {
			this.activityContext = activityContext;
			if(activityContext!=null){
				activityCancellationSubscription.Disposable = 
					activityContext.RegisterCancellationCallback(() => {
						EnsureAccess(() => {
							CompleteWith(() => {
								if(OnCancelled!=null){
									OnCancelled();
								}
							});
						});
					});
			}
			Init(model);
		}

		
		public void EnsureAccess(Action action){
			if(!CheckAccess()){
				Dispatcher.Invoke(action);
			}else{
				action();
			}
		}

		public void CompleteWith(Action cont){
			if(!activityCompleted){
				activityCompleted = true;
				cont();
				if(OnCompleted!=null){
					OnCompleted();
				}
				activityCancellationSubscription.Dispose();
			}
		}
		public void Success(Result result) {
			CompleteWith(() => {
				if(activityContext!=null){
					activityContext.Success(result);
				}
				if(OnSuccess!=null){
					OnSuccess(result);
				}
			});
		}
		public void Error(Exception error) {
			CompleteWith(() => {
				if(activityContext!=null){
					activityContext.Error(error);
				}
				if(OnError!=null){
					OnError(error);
				}
			});
		}
		public void Cancel() {
			CompleteWith(() => {
				if(activityContext!=null){
					activityContext.Cancel();
				}
				if(OnCancelled!=null){
					OnCancelled();
				}
			});
		}
		public void Success(Func<Result> resultFactory) {
			CompleteWith(() => {
				var result = resultFactory();
				if(activityContext!=null){
					activityContext.Success(result);
				}
				if(OnSuccess!=null){
					OnSuccess(result);
				}
			});
		}
		public void Error(Func<Exception> errorFactory) {
			CompleteWith(() => {
				var error = errorFactory();
				if(activityContext!=null){
					activityContext.Error(error);
				}
				if(OnError!=null){
					OnError(error);
				}
			});
		}
		public void Cancel(Action action) {
			CompleteWith(() => {
				action();
				if(activityContext!=null){
					activityContext.Cancel();
				}
				if(OnCancelled!=null){
					OnCancelled();
				}
			});
		}
		
	}
}
