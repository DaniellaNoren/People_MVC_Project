(this["webpackJsonppeople-frontend"]=this["webpackJsonppeople-frontend"]||[]).push([[0],{16:function(e,t,n){},32:function(e,t,n){},54:function(e,t,n){"use strict";n.r(t);var a=n(3),s=n.n(a),r=n(25),c=n.n(r),o=(n(16),n(32),n(12)),i=n(9),l=n(10),u=n(13),h=n(11),j=n(4),d=n.n(j),b=n(27),p=(n(51),n(0)),m=function(e){var t=e.person;return Object(p.jsxs)("table",{className:"table",children:[Object(p.jsx)("thead",{children:Object(p.jsxs)("tr",{children:[Object(p.jsx)("th",{children:"City"}),Object(p.jsx)("th",{children:"SSN"}),Object(p.jsx)("th",{children:"Phone"}),Object(p.jsx)("th",{children:"Action"})]})}),Object(p.jsx)("tbody",{children:Object(p.jsxs)("tr",{children:[Object(p.jsxs)("td",{children:[" ",t.city.name]}),Object(p.jsx)("td",{children:t.socialSecurityNr}),Object(p.jsx)("td",{children:t.phoneNr})]})})]})};function f(e){var t=e.person,n=e.deletePersonFunction,a=s.a.useState(!1),r=Object(b.a)(a,2),c=r[0],o=r[1];return c?Object(p.jsxs)("tr",{children:[Object(p.jsx)("td",{children:Object(p.jsx)("button",{onClick:function(){return n(t)},className:"btn btn-warning",children:"DELETE"})}),Object(p.jsx)("td",{className:"person-details",children:Object(p.jsx)(m,{person:t,deletePersonFunction:n})}),Object(p.jsx)("td",{children:Object(p.jsx)("button",{className:"btn btn-primary",onClick:function(){return o(!1)},children:"Hide details"})})]}):Object(p.jsxs)("tr",{children:[Object(p.jsx)("td",{children:t.firstName}),Object(p.jsx)("td",{children:t.lastName}),Object(p.jsxs)("td",{children:[" ",Object(p.jsx)("button",{className:"btn btn-primary",onClick:function(){return o(!0)},children:"'Show details'"})]})]})}var O=function(e){var t=e.people,n=e.deletePersonFunction;return Object(p.jsxs)("table",{className:"table",children:[Object(p.jsx)("thead",{className:"thead-dark",children:Object(p.jsxs)("tr",{children:[Object(p.jsx)("th",{children:"Name"}),Object(p.jsx)("th",{children:"Lastname"})]})}),Object(p.jsx)("tbody",{children:t.map((function(e){return Object(p.jsx)(f,{deletePersonFunction:n,person:e},e.id)}))})]})},g=n(15),x=n.n(g),N=n(1),v=n(26),S="https://localhost:44350/react",y=function(e){Object(u.a)(n,e);var t=Object(h.a)(n);function n(){var e;Object(i.a)(this,n);for(var a=arguments.length,s=new Array(a),r=0;r<a;r++)s[r]=arguments[r];return(e=t.call.apply(t,[this].concat(s))).state={showWarning:!1,warning:"",person:{FirstName:"",LastName:"",CityId:0,PhoneNr:"",SocialSecurityNr:"",LanguageIds:[]},countries:[],cities:[],languages:[]},e}return Object(l.a)(n,[{key:"checkPerson",value:function(){var e=new RegExp("[a-zA-Z]");""!==this.state.person.FirstName&&""!==this.state.person.LastName?e.test(this.state.person.PhoneNr)?this.setState({showWarning:!0,warning:"Invalid phonenumber"}):e.test(this.state.person.SocialSecurityNr)||this.state.person.SocialSecurityNr.length<10||this.state.person.SocialSecurityNr.length>12?this.setState({showWarning:!0,warning:"Invalid SNN"}):(this.setState({showWarning:!1,warning:""}),this.props.handleSubmit(this.state.person)):this.setState({showWarning:!0,warning:"Name has to be filled in"})}},{key:"componentDidMount",value:function(){var e=Object(v.a)(x.a.mark((function e(){var t=this;return x.a.wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return e.next=2,d.a.get("".concat(S,"/countries")).then((function(e){t.setState({countries:e.data.countries})})).then((function(){t.setState({cities:t.state.countries.flatMap((function(e){return e.cities}))})})).then((function(){t.setState({person:Object(N.a)(Object(N.a)({},t.state.person),{},{CityId:t.state.cities[0].id})})})).catch((function(e){console.log(e)}));case 2:return e.next=4,d.a.get("".concat(S,"/languages")).then((function(e){t.setState({languages:e.data.languages})})).catch((function(e){console.log(e)}));case 4:case"end":return e.stop()}}),e)})));return function(){return e.apply(this,arguments)}}()},{key:"render",value:function(){var e=this;return Object(p.jsx)("div",{className:"bg-light d-flex justify-content-center m-2",children:Object(p.jsxs)("form",{onSubmit:function(t){t.preventDefault(),e.checkPerson()},className:"create-person-form",children:[this.state.showWarning?Object(p.jsx)("p",{className:"form-text text-warning",children:this.state.warning}):null,Object(p.jsxs)("div",{className:"form-group",children:[Object(p.jsx)("label",{for:"FirstName",children:"Firstname:"}),Object(p.jsx)("input",{className:"form-control",id:"FirstName",value:this.state.person.FirstName,onChange:function(t){e.setState({person:Object(N.a)(Object(N.a)({},e.state.person),{},{FirstName:t.target.value})})},type:"text",required:!0})]}),Object(p.jsxs)("div",{className:"form-group",children:[Object(p.jsx)("label",{for:"LastName",children:"Lastname:"}),Object(p.jsx)("input",{className:"form-control",value:this.state.person.LastName,onChange:function(t){e.setState({person:Object(N.a)(Object(N.a)({},e.state.person),{},{LastName:t.target.value})})},type:"text",id:"LastName"})]}),Object(p.jsxs)("div",{className:"form-group",children:[Object(p.jsx)("label",{for:"PhoneNr",children:"Phone:"}),Object(p.jsx)("input",{className:"form-control",value:this.state.person.PhoneNr,onChange:function(t){e.setState({person:Object(N.a)(Object(N.a)({},e.state.person),{},{PhoneNr:t.target.value})})},type:"tel",id:"PhoneNr",required:!0})]}),Object(p.jsxs)("div",{className:"form-group",children:[Object(p.jsx)("label",{for:"SSN",children:"SSN:"}),Object(p.jsx)("input",{className:"form-control",value:this.state.person.SocialSecurityNr,onChange:function(t){e.setState({person:Object(N.a)(Object(N.a)({},e.state.person),{},{SocialSecurityNr:t.target.value})})},type:"number",id:"SSN",required:!0})]}),Object(p.jsxs)("div",{className:"form-group",children:[Object(p.jsx)("label",{for:"City",children:"City:"}),Object(p.jsx)("select",{className:"form-control",id:"city",name:"cities",type:"text",defaultValue:0,onChange:function(t){e.setState({person:Object(N.a)(Object(N.a)({},e.state.person),{},{CityId:parseInt(t.target.value)})})},required:!0,children:this.state.cities.map((function(e){return Object(p.jsx)("option",{value:e.id,children:e.name},e.name)}))})]}),Object(p.jsxs)("div",{className:"form-group",children:[Object(p.jsx)("label",{for:"Languages",children:"Languages:"}),Object(p.jsx)("select",{className:"form-control",multiple:!0,name:"languages",type:"text",defaultValue:[],onChange:function(t){e.setState({person:Object(N.a)(Object(N.a)({},e.state.person),{},{LanguageIds:[].concat(Object(o.a)(e.state.person.LanguageIds),[parseInt(t.target.value)])})})},id:"languages",required:!0,children:this.state.languages.map((function(e){return Object(p.jsx)("option",{value:e.id,children:e.languageName},e.id)}))})]}),Object(p.jsx)("button",{className:"mt-3 ml-5 btn btn-primary",children:"Create"})]})})}}]),n}(s.a.Component),w="window.location.href",C=function(e){Object(u.a)(n,e);var t=Object(h.a)(n);function n(){var e;Object(i.a)(this,n);for(var a=arguments.length,s=new Array(a),r=0;r<a;r++)s[r]=arguments[r];return(e=t.call.apply(t,[this].concat(s))).state={showCreateForm:!1,people:[]},e.addNewPerson=function(t){var n=JSON.stringify(t);d.a.post("".concat(w,"/people"),n,{headers:{"Content-Type":"application/json"}}).then((function(t){e.setState((function(e){return{people:[].concat(Object(o.a)(e.people),[t.data])}}))})).then((function(){e.setState({showCreateForm:!1})})).catch((function(e){console.log(e)}))},e.removePerson=function(t){d.a.delete("".concat(w,"/people/").concat(t.id)).then((function(n){200===n.status&&e.setState((function(e){return{people:e.people.filter((function(e){return e.id!==t.id}))}}))})).catch((function(e){console.log(e)}))},e.sortPeopleByName=function(){e.setState((function(e){return{people:e.people.sort((function(e,t){return e.firstName<t.firstName?-1:t.firstName<e.firstName?1:0}))}}))},e}return Object(l.a)(n,[{key:"componentDidMount",value:function(){var e=this;d.a.get("".concat(w,"/people")).then((function(t){e.setState({people:t.data.people})})).catch((function(e){console.log(e)}))}},{key:"render",value:function(){var e=this;return Object(p.jsxs)("div",{children:[Object(p.jsx)("div",{className:"row",children:Object(p.jsx)("button",{className:"col-lg-1 mt-3 ml-5 btn btn-primary sort-btn",onClick:this.sortPeopleByName,children:"SORT BY NAME"})}),Object(p.jsx)(O,{deletePersonFunction:this.removePerson,people:this.state.people}),Object(p.jsx)("button",{onClick:function(){return e.setState((function(e){return{showCreateForm:!e.showCreateForm}}))},className:"btn btn-primary",children:this.state.showCreateForm?"Hide":"Create person"}),this.state.showCreateForm?Object(p.jsx)(y,{handleSubmit:this.addNewPerson}):null]})}}]),n}(s.a.Component);var P=function(){return Object(p.jsx)("div",{className:"App",children:Object(p.jsx)(C,{})})},F=function(e){e&&e instanceof Function&&n.e(3).then(n.bind(null,55)).then((function(t){var n=t.getCLS,a=t.getFID,s=t.getFCP,r=t.getLCP,c=t.getTTFB;n(e),a(e),s(e),r(e),c(e)}))};c.a.render(Object(p.jsx)(s.a.StrictMode,{children:Object(p.jsx)(P,{})}),document.getElementById("root")),F()}},[[54,1,2]]]);
//# sourceMappingURL=main.7f74c94b.chunk.js.map