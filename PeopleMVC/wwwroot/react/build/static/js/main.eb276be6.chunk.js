(this["webpackJsonppeople-frontend"]=this["webpackJsonppeople-frontend"]||[]).push([[0],{28:function(e,t,n){},29:function(e,t,n){},50:function(e,t,n){"use strict";n.r(t);var a=n(3),o=n.n(a),s=n(22),c=n.n(s),r=(n(28),n(29),n(13)),i=n(12),u=n.n(i),l=n(1),p=n(23),h=n(7),j=n(8),d=n(10),f=n(9),b=n(4),O=n.n(b),g=n(0),m=window.location.href,v=function(e){Object(d.a)(n,e);var t=Object(f.a)(n);function n(){var e;Object(h.a)(this,n);for(var a=arguments.length,o=new Array(a),s=0;s<a;s++)o[s]=arguments[s];return(e=t.call.apply(t,[this].concat(o))).state={person:{FirstName:"",LastName:"",CityId:0,PhoneNr:"",SocialSecurityNr:"",LanguageIds:[]},countries:[],cities:[],languages:[]},e}return Object(j.a)(n,[{key:"componentDidMount",value:function(){var e=Object(p.a)(u.a.mark((function e(){var t=this;return u.a.wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return e.next=2,O.a.get("".concat(m,"/countries")).then((function(e){t.setState({countries:e.data.countries})})).then((function(){t.setState({cities:t.state.countries.flatMap((function(e){return e.cities}))})})).then((function(){t.setState({person:Object(l.a)(Object(l.a)({},t.state.person),{},{CityId:t.state.cities[0].id})})})).catch((function(e){console.log(e)}));case 2:return e.next=4,O.a.get("".concat(m,"/languages")).then((function(e){t.setState({languages:e.data.languages})})).catch((function(e){console.log(e)}));case 4:case"end":return e.stop()}}),e)})));return function(){return e.apply(this,arguments)}}()},{key:"render",value:function(){var e=this;return Object(g.jsxs)("form",{onSubmit:function(t){t.preventDefault(),e.props.handleSubmit(e.state.person)},children:[Object(g.jsx)("input",{value:this.state.person.FirstName,onChange:function(t){e.setState({person:Object(l.a)(Object(l.a)({},e.state.person),{},{FirstName:t.target.value})})},type:"text",required:!0}),Object(g.jsx)("input",{value:this.state.person.LastName,onChange:function(t){e.setState({person:Object(l.a)(Object(l.a)({},e.state.person),{},{LastName:t.target.value})})},type:"text"}),Object(g.jsx)("input",{value:this.state.person.PhoneNr,onChange:function(t){e.setState({person:Object(l.a)(Object(l.a)({},e.state.person),{},{PhoneNr:t.target.value})})},type:"text"}),Object(g.jsx)("input",{value:this.state.person.SocialSecurityNr,onChange:function(t){e.setState({person:Object(l.a)(Object(l.a)({},e.state.person),{},{SocialSecurityNr:t.target.value})})},type:"text"}),Object(g.jsx)("select",{id:"cities",name:"cities",type:"text",defaultValue:0,onChange:function(t){e.setState({person:Object(l.a)(Object(l.a)({},e.state.person),{},{CityId:parseInt(t.target.value)})})},children:this.state.cities.map((function(e){return Object(g.jsx)("option",{value:e.id,children:e.name},e.name)}))}),Object(g.jsx)("select",{multiple:!0,id:"languages",name:"languages",type:"text",defaultValue:[],onChange:function(t){e.setState({person:Object(l.a)(Object(l.a)({},e.state.person),{},{LanguageIds:[].concat(Object(r.a)(e.state.person.LanguageIds),[parseInt(t.target.value)])})})},children:this.state.languages.map((function(e){return Object(g.jsx)("option",{value:e.id,children:e.languageName},e.id)}))}),Object(g.jsx)("button",{children:"Create person"})]})}}]),n}(o.a.Component),x=function(e){var t=e.person,n=e.deletePersonFunction;return Object(g.jsxs)("div",{children:[t.city.name,t.socialSecurityNr,t.phoneNr,Object(g.jsx)("button",{onClick:function(){return n(t)},children:"DELETE"})]})},S=function(e){Object(d.a)(n,e);var t=Object(f.a)(n);function n(){var e;Object(h.a)(this,n);for(var a=arguments.length,o=new Array(a),s=0;s<a;s++)o[s]=arguments[s];return(e=t.call.apply(t,[this].concat(o))).state={showDetails:!1},e.person=e.props.person,e.setShowDetails=function(t){e.setState({showDetails:t})},e}return Object(j.a)(n,[{key:"render",value:function(){var e=this;return Object(g.jsxs)("tr",{children:[Object(g.jsx)("td",{children:this.person.firstName}),Object(g.jsx)("td",{children:this.person.lastName}),Object(g.jsx)("td",{children:Object(g.jsx)("button",{onClick:function(){return e.setShowDetails(!e.state.showDetails)},children:"Show details"})}),this.state.showDetails?Object(g.jsx)("td",{children:Object(g.jsx)(x,{person:this.person,deletePersonFunction:this.props.deletePersonFunction})}):null]})}}]),n}(o.a.Component),y=function(e){var t=e.people,n=e.deletePersonFunction;return Object(g.jsxs)("table",{children:[Object(g.jsx)("thead",{children:Object(g.jsxs)("tr",{children:[Object(g.jsx)("th",{children:"Name"}),Object(g.jsx)("th",{children:"Lastname"}),Object(g.jsx)("th",{children:"City"})]})}),Object(g.jsx)("tbody",{children:t.map((function(e){return Object(g.jsx)(S,{deletePersonFunction:n,person:e},e.id)}))})]})},N=function(e){Object(d.a)(n,e);var t=Object(f.a)(n);function n(){var e;Object(h.a)(this,n);for(var a=arguments.length,o=new Array(a),s=0;s<a;s++)o[s]=arguments[s];return(e=t.call.apply(t,[this].concat(o))).state={showCreateForm:!1,people:[]},e.addNewPerson=function(t){var n=JSON.stringify(t);console.log(n),O.a.post("".concat(m,"/people"),n,{headers:{"Content-Type":"application/json"}}).then((function(t){e.setState((function(e){return{people:[].concat(Object(r.a)(e.people),[t.data])}}))})).then((function(){e.setState({showCreateForm:!1})})).catch((function(e){console.log(e)}))},e.removePerson=function(t){O.a.delete("".concat(m,"/people/").concat(t.id)).then((function(n){200===n.status&&e.setState((function(e){return{people:e.people.filter((function(e){return e.id!==t.id}))}}))})).catch((function(e){console.log(e)}))},e.sortPeopleByName=function(){e.setState((function(e){return{people:e.people.sort((function(e,t){return e.firstName<t.firstName?-1:t.firstName<e.firstName?1:0}))}}))},e}return Object(j.a)(n,[{key:"componentDidMount",value:function(){var e=this;O.a.get("".concat(m,"/people")).then((function(t){e.setState({people:t.data.people})})).catch((function(e){console.log(e)}))}},{key:"render",value:function(){var e=this;return Object(g.jsxs)("div",{children:[Object(g.jsx)("button",{onClick:this.sortPeopleByName,children:"SORT BY NAME"}),Object(g.jsx)(y,{deletePersonFunction:this.removePerson,people:this.state.people}),Object(g.jsx)("button",{onClick:function(){return e.setState((function(e){return{showCreateForm:!e.showCreateForm}}))},children:"Create person"}),this.state.showCreateForm?Object(g.jsx)(v,{handleSubmit:this.addNewPerson}):null]})}}]),n}(o.a.Component);var C=function(){return Object(g.jsx)("div",{className:"App",children:Object(g.jsx)(N,{})})},w=function(e){e&&e instanceof Function&&n.e(3).then(n.bind(null,51)).then((function(t){var n=t.getCLS,a=t.getFID,o=t.getFCP,s=t.getLCP,c=t.getTTFB;n(e),a(e),o(e),s(e),c(e)}))};c.a.render(Object(g.jsx)(o.a.StrictMode,{children:Object(g.jsx)(C,{})}),document.getElementById("root")),w()}},[[50,1,2]]]);
//# sourceMappingURL=main.eb276be6.chunk.js.map