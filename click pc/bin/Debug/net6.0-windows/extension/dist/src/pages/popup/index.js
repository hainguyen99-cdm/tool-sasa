var R=Object.defineProperty;var A=(r,t,s)=>t in r?R(r,t,{enumerable:!0,configurable:!0,writable:!0,value:s}):r[t]=s;var L=(r,t,s)=>(A(r,typeof t!="symbol"?t+"":t,s),s);import{j as e,r as c,u as O,C as B,T as U,a as z,b as $,G,P as V,c as H,d as J,t as K,e as p,E as Y,g as Z,B as Q,f as y,h as X,i as C,k as E,D as ee,s as te,W as re,l as se,S as oe,m as ne,n as ae,o as ie,p as le,q as ce,v as de,H as ue,w as he,x as me,y as pe,z as ge,A as w,F as fe,I as xe,J as ve,R as je,N as Se}from"../../../assets/js/NotiSSE.logJ_2QI.js";import"../../../assets/js/base.CKaqUdIP.js";import"../../../assets/js/_commonjsHelpers.BosuxZz1.js";function D(r,t){return function(o){return e.jsx(c.Suspense,{fallback:t,children:e.jsx(r,{...o})})}}class Ce extends c.Component{constructor(){super(...arguments);L(this,"state",{hasError:!1})}static getDerivedStateFromError(){return{hasError:!0}}componentDidCatch(s,o){console.error(s,o)}render(){return this.state.hasError?this.props.fallback:this.props.children}}function N(r,t){return function(o){return e.jsx(Ce,{fallback:t,children:e.jsx(r,{...o})})}}var S={light:"chakra-ui-light",dark:"chakra-ui-dark"};function we(r={}){const{preventTransition:t=!0}=r,s={setDataset:o=>{const n=t?s.preventTransition():void 0;document.documentElement.dataset.theme=o,document.documentElement.style.colorScheme=o,n==null||n()},setClassName(o){document.body.classList.add(o?S.dark:S.light),document.body.classList.remove(o?S.light:S.dark)},query(){return window.matchMedia("(prefers-color-scheme: dark)")},getSystemTheme(o){var n;return((n=s.query().matches)!=null?n:o==="dark")?"dark":"light"},addListener(o){const n=s.query(),a=l=>{o(l.matches?"dark":"light")};return typeof n.addListener=="function"?n.addListener(a):n.addEventListener("change",a),()=>{typeof n.removeListener=="function"?n.removeListener(a):n.removeEventListener("change",a)}},preventTransition(){const o=document.createElement("style");return o.appendChild(document.createTextNode("*{-webkit-transition:none!important;-moz-transition:none!important;-o-transition:none!important;-ms-transition:none!important;transition:none!important}")),document.head.appendChild(o),()=>{window.getComputedStyle(document.body),requestAnimationFrame(()=>{requestAnimationFrame(()=>{document.head.removeChild(o)})})}}};return s}var ye="chakra-ui-color-mode";function Ee(r){return{ssr:!1,type:"localStorage",get(t){if(!(globalThis!=null&&globalThis.document))return t;let s;try{s=localStorage.getItem(r)||t}catch{}return s||t},set(t){try{localStorage.setItem(r,t)}catch{}}}}var ke=Ee(ye),T=()=>{};function W(r,t){return r.type==="cookie"&&r.ssr?r.get(t):t}function F(r){const{value:t,children:s,options:{useSystemColorMode:o,initialColorMode:n,disableTransitionOnChange:a}={},colorModeManager:l=ke}=r,i=n==="dark"?"dark":"light",[d,g]=c.useState(()=>W(l,i)),[f,m]=c.useState(()=>W(l)),{getSystemTheme:u,setClassName:k,setDataset:P,addListener:M}=c.useMemo(()=>we({preventTransition:a}),[a]),v=n==="system"&&!d?f:d,h=c.useCallback(x=>{const j=x==="system"?u():x;g(j),k(j==="dark"),P(j),l.set(j)},[l,u,k,P]);O(()=>{n==="system"&&m(u())},[]),c.useEffect(()=>{const x=l.get();if(x){h(x);return}if(n==="system"){h("system");return}h(i)},[l,i,n,h]);const b=c.useCallback(()=>{h(v==="dark"?"light":"dark")},[v,h]);c.useEffect(()=>{if(o)return M(h)},[o,M,h]);const q=c.useMemo(()=>({colorMode:t??v,toggleColorMode:t?T:b,setColorMode:t?T:h,forced:t!==void 0}),[v,b,h,t]);return e.jsx(B.Provider,{value:q,children:s})}F.displayName="ColorModeProvider";var _=c.createContext({getDocument(){return document},getWindow(){return window}});_.displayName="EnvironmentContext";function I(r){const{children:t,environment:s,disabled:o}=r,n=c.useRef(null),a=c.useMemo(()=>s||{getDocument:()=>{var i,d;return(d=(i=n.current)==null?void 0:i.ownerDocument)!=null?d:document},getWindow:()=>{var i,d;return(d=(i=n.current)==null?void 0:i.ownerDocument.defaultView)!=null?d:window}},[s]),l=!o||!s;return e.jsxs(_.Provider,{value:a,children:[t,l&&e.jsx("span",{id:"__chakra_env",hidden:!0,ref:n})]})}I.displayName="EnvironmentProvider";var Pe=r=>{const{children:t,colorModeManager:s,portalZIndex:o,resetScope:n,resetCSS:a=!0,theme:l={},environment:i,cssVarsRoot:d,disableEnvironment:g,disableGlobalStyle:f}=r,m=e.jsx(I,{environment:i,disabled:g,children:t});return e.jsx(U,{theme:l,cssVarsRoot:d,children:e.jsxs(F,{colorModeManager:s,options:l.config,children:[a?e.jsx(z,{scope:n}):e.jsx($,{}),!f&&e.jsx(G,{}),o?e.jsx(V,{zIndex:o,children:m}):m]})})},Me=r=>function({children:s,theme:o=r,toastOptions:n,...a}){return e.jsxs(Pe,{theme:o,...a,children:[e.jsx(H,{value:n==null?void 0:n.defaultOptions,children:s}),e.jsx(J,{...n})]})},be=Me(K);function Le(){const{saxTheme:r}=p(s=>s.displaySasa),t=async()=>{var o;const s=await X();(s==null?void 0:s.status)===200&&window.open((o=s==null?void 0:s.data)==null?void 0:o.redirectUrl)};return e.jsxs("div",{className:"no-auth",children:[e.jsx("a",{href:Y,target:"_blank",rel:"noreferrer",children:e.jsx("img",{src:Z("/img/sa.png"),alt:"",className:"logo-saw"})}),e.jsx(Q,{style:{background:r==="dark"?"#faad14":"#1890FF",color:r==="dark"?"#000":"#fff"},onClick:t,className:"button-login",children:y("login")})]})}const Te=()=>{const r=C(),t=()=>{r(te(!1))};return e.jsx(E,{title:y("deposit"),onClosePage:t,children:e.jsx(ee,{})})};function We(){const r=C(),t=()=>{r(se(!1))};return e.jsx(E,{title:y("transfer"),onClosePage:t,children:e.jsx(re,{})})}const De=()=>{const r=C(),t=()=>{r(ne(!1))};return e.jsx(E,{title:"Swap",onClosePage:t,children:e.jsx(oe,{})})},Ne=()=>{const{styles:r}=p(u=>u.displaySasa),{isInitialized:t,maintain:s}=p(u=>u.maintain);ae();const{loading:o}=p(u=>u.user),{isDeposit:n,isWithDraw:a,isSwap:l,isImportPassword:i,isChangePassword:d,isExportWallet:g,isLogin:f,isExportWalletSuccess:m}=p(u=>u.popup);return e.jsx("div",{className:`sasa-popup ${f?"":"not-logged"}`,style:r==null?void 0:r.bgStyle,children:t&&e.jsx(e.Fragment,{children:e.jsx(e.Fragment,{children:f?e.jsx(e.Fragment,{children:!o&&e.jsx(e.Fragment,{children:i?e.jsxs(e.Fragment,{children:[n&&e.jsx(Te,{}),l&&e.jsx(De,{}),a&&e.jsx(We,{}),d&&e.jsx(le,{}),g&&e.jsx(ce,{}),m&&e.jsx(de,{}),!(n||l||a||d||g||m)&&e.jsx(ue,{})]}):e.jsx(ie,{})})}):e.jsx(Le,{})})})})},Fe=N(D(Ne,e.jsx("div",{children:" Loading ... "})),e.jsx("div",{children:" Error Occur "})),_e=()=>{he(),me(),pe();const{saxTheme:r}=p(a=>a.displaySasa),t=C(),{token:s}=ge(),{error:o}=p(a=>a.user);c.useEffect(()=>{s?(t(w(!0)),t(fe(s))):t(w(!1))},[s]),c.useEffect(()=>{var a,l;if(r){const i=document.querySelector("#app-container");i&&(i.className="",i==null||i.classList.add(`app-container-${r}`),(l=(a=i==null?void 0:i.parentElement)==null?void 0:a.parentElement)==null||l.classList.add(`html-${r}`))}},[r]);const n=()=>{t(w(!1)),chrome.storage.local.clear(),chrome.storage.session.clear(),t(xe(!1))};return c.useEffect(()=>{o.toLowerCase()==="error"&&n()},[o]),e.jsx(e.Fragment,{children:e.jsx(Fe,{})})},Ie=N(D(_e,e.jsx("div",{children:" Loading ... "})),e.jsx("div",{children:" Error Occur "}));function qe(){const r=document.querySelector("#app-container");if(!r)throw new Error("Can not find #app-container");ve(r).render(e.jsx(be,{toastOptions:{defaultOptions:{position:"top",isClosable:!0,duration:3e3}},children:e.jsx(je,{children:e.jsx(Se,{children:e.jsx(Ie,{})})})}))}qe();
