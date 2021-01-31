using UnityEngine;
using Zenject;

namespace Jamjardavies.Zenject.ViewController
{
    public interface IController : IInitializable, System.IDisposable { }

    public abstract class Controller : IController
    {
        public virtual void Initialize()
        {
            Initialise();
        }

        public virtual void Dispose()
        {
            OnDestroy();
        }

        public abstract void Initialise();
        public abstract void OnDestroy();

        public class TransientFactory : IFactory<System.Type, IController>
        {
            [Inject]
            private DiContainer m_container = null;

            [Inject]
            public TransientFactory()
            {
                // #JD 09/05/2016: This is required for IL2CPP.
            }

            public IController Create(System.Type type)
            {
                return Create(type, null);
            }

            public IController Create(System.Type type, params object[] args)
            {
                // #JD 17/03/2016: Only create if we have the controller bound.
                if (!m_container.HasBinding(new InjectContext(m_container, type)))
                {
                    return null;
                }

                if (args == null)
                {
                    return (IController)m_container.Instantiate(type);
                }

                return (IController)m_container.Instantiate(type, args);
            }
        }
    }

    public abstract class Controller<T> : Controller
        where T : View
    {
        #region 新加的

        private DiContainer mContainerInstance;
        [Inject]
        private DiContainer mContainer {
            get { return mContainerInstance; }
            set {

                Debug.Log(GetType()+ "/DiContainer Setter()/……");

                mContainerInstance = value;

                // 资源路径和名称被局限了
                value.Bind<T>()
                    .FromComponentInNewPrefabResource(typeof(T).Name)
                    .WithGameObjectName(typeof(T).Name)
                    .UnderTransform(ctx => ctx.Container.ResolveId<RectTransform>("UIRoot"))
                    .AsCached();
            }
        }

        #endregion

        
        private T mView = null;

        private event System.Action<Controller<T>> m_disposed = delegate { };

        public event System.Action<Controller<T>> Disposed
        {
            add { m_disposed += value; }
            remove { m_disposed -= value; }
        }

        [Inject]
        public T View
        {
            get { return mView; }
            set { mView = value; }
        }

        public override void Dispose()
        {
            base.Dispose();
            if (View)
            {
                Object.Destroy(View.gameObject);

            }

            // 新加
            mContainerInstance.Unbind<T>();

            m_disposed.Invoke(this);
        }
    }
}