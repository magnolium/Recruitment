import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

    componentDidMount() {
        console.log("~Start");
        this.GetAddressBookData();
    }

    GetAddressBookData() {
        console.log("GetAddressBookData");
        fetch('api/GetAddressBook/Addressbook')
            .then(response => response.json())
            .then(data => {
                console.log("Address:", data);
            });
    }

  render () {
    return (
      <div>
        <h1>Hello, CBRE!</h1>
      </div>
    );
  }
}
